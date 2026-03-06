using System;

namespace Service
{
    /// <summary>
    /// Содержит реализацию алгоритмов слияния двух отсортированных массивов
    /// </summary>
    public static class MergeAlgorithms
    {
        /// <summary>
        /// Выполняет простое слияние двух отсортированных массивов с созданием нового массива
        /// </summary>
        /// <param name="firstArray">Первый отсортированный массив</param>
        /// <param name="secondArray">Второй отсортированный массив</param>
        /// <param name="operationCount">Количество выполненных элементарных операций (выходной параметр)</param>
        /// <returns>Новый отсортированный массив, содержащий все элементы из обоих исходных массивов</returns>
        public static int[] SimpleMerge(int[] firstArray, int[] secondArray, out long operationCount)
        {
            // Инициализация счетчика операций
            operationCount = 0;

            // Определение длин исходных массивов
            int firstArrayLength = firstArray.Length;
            int secondArrayLength = secondArray.Length;

            // Создание результирующего массива, размер которого равен сумме размеров исходных
            int[] mergedArray = new int[firstArrayLength + secondArrayLength];

            // Индексы для прохода по массивам:
            // firstArrayIndex - индекс в первом массиве
            // secondArrayIndex - индекс во втором массиве
            // mergedArrayIndex - индекс в результирующем массиве
            int firstArrayIndex = 0;
            int secondArrayIndex = 0;
            int mergedArrayIndex = 0;

            // Основной цикл слияния: пока не достигли конца хотя бы одного из массивов
            while (firstArrayIndex < firstArrayLength && secondArrayIndex < secondArrayLength)
            {
                // Учитываем операцию сравнения двух элементов
                operationCount++;

                // Сравниваем текущие элементы первого и второго массивов
                if (firstArray[firstArrayIndex] <= secondArray[secondArrayIndex])
                {
                    // Если элемент первого массива меньше или равен, копируем его в результат
                    mergedArray[mergedArrayIndex] = firstArray[firstArrayIndex];

                    // Перемещаем указатели вперед
                    firstArrayIndex++;
                    mergedArrayIndex++;

                    // Учитываем операции копирования и инкремента (условно как одну операцию)
                    operationCount++;
                }
                else
                {
                    // Иначе копируем элемент из второго массива
                    mergedArray[mergedArrayIndex] = secondArray[secondArrayIndex];

                    // Перемещаем указатели вперед
                    secondArrayIndex++;
                    mergedArrayIndex++;

                    // Учитываем операции копирования и инкремента
                    operationCount++;
                }
            }

            // Копирование оставшихся элементов из первого массива (если они есть)
            while (firstArrayIndex < firstArrayLength)
            {
                mergedArray[mergedArrayIndex] = firstArray[firstArrayIndex];
                firstArrayIndex++;
                mergedArrayIndex++;

                // Учитываем операцию копирования
                operationCount++;
            }

            // Копирование оставшихся элементов из второго массива (если они есть)
            while (secondArrayIndex < secondArrayLength)
            {
                mergedArray[mergedArrayIndex] = secondArray[secondArrayIndex];
                secondArrayIndex++;
                mergedArrayIndex++;

                // Учитываем операцию копирования
                operationCount++;
            }

            return mergedArray;
        }

        /// <summary>
        /// Выполняет слияние двух отсортированных массивов методом "на месте" (in-place)
        /// с использованием циклических сдвигов элементов
        /// </summary>
        /// <param name="firstArray">Первый отсортированный массив</param>
        /// <param name="secondArray">Второй отсортированный массив</param>
        /// <param name="operationCount">Количество выполненных элементарных операций (выходной параметр)</param>
        /// <returns>Новый отсортированный массив, содержащий все элементы</returns>
        public static int[] InPlaceMerge(int[] firstArray, int[] secondArray, out long operationCount)
        {
            operationCount = 0;

            int firstArrayLength = firstArray.Length;
            int secondArrayLength = secondArray.Length;

            // Создаем общий массив, содержащий все элементы из обоих исходных массивов
            int[] mergedArray = new int[firstArrayLength + secondArrayLength];

            // Копируем элементы первого массива в начало общего массива
            Array.Copy(firstArray, 0, mergedArray, 0, firstArrayLength);
            // Копируем элементы второго массива в конец общего массива
            Array.Copy(secondArray, 0, mergedArray, firstArrayLength, secondArrayLength);

            // Учитываем операции копирования
            operationCount += firstArrayLength + secondArrayLength;

            // Определяем границы для слияния:
            // leftBound - начало первой половины (левая граница)
            // middleBound - начало второй половины (середина)
            // rightBound - конец второй половины (правая граница, не включительно)
            int leftBound = 0;
            int middleBound = firstArrayLength;
            int rightBound = firstArrayLength + secondArrayLength;

            // Вызов внутреннего метода для выполнения слияния "на месте"
            InPlaceMergeInternal(mergedArray, leftBound, middleBound, rightBound, ref operationCount);

            return mergedArray;
        }

        /// <summary>
        /// Внутренний метод для слияния двух отсортированных частей массива "на месте"
        /// </summary>
        /// <param name="array">Массив, содержащий две отсортированные части</param>
        /// <param name="leftBound">Левая граница первой части (включительно)</param>
        /// <param name="middleBound">Граница между первой и второй частью (начало второй части)</param>
        /// <param name="rightBound">Правая граница второй части (не включительно)</param>
        /// <param name="opCount">Счетчик операций (передается по ссылке)</param>
        private static void InPlaceMergeInternal(int[] array, int leftBound, int middleBound, int rightBound, ref long opCount)
        {
            // Указатель i движется по первой части (от leftBound до middleBound)
            // Указатель j движется по второй части (от middleBound до rightBound)
            int i = leftBound;
            int j = middleBound;

            // Продолжаем, пока не достигли конца первой части и не вышли за границы второй
            while (i < j && j < rightBound)
            {
                // Учитываем операцию сравнения элементов
                opCount++;

                // Если элемент из первой части больше элемента из второй части,
                // значит элемент из второй части должен стоять раньше
                if (array[i] > array[j])
                {
                    // Сохраняем значение элемента из второй части
                    int tempValue = array[j];
                    opCount++; // Учитываем присваивание

                    // Выполняем циклический сдвиг элементов вправо для освобождения места
                    // Сдвигаем все элементы с позиции i до j-1 на одну позицию вправо
                    for (int k = j; k > i; k--)
                    {
                        array[k] = array[k - 1];
                        opCount++; // Учитываем каждое присваивание при сдвиге
                    }

                    // Помещаем сохраненный элемент на освободившееся место
                    array[i] = tempValue;
                    opCount++; // Учитываем присваивание

                    // Перемещаем оба указателя вперед
                    i++;
                    j++;
                }
                else
                {
                    // Если элемент на своем месте, просто двигаем указатель i
                    i++;
                }
            }
        }
    }
}