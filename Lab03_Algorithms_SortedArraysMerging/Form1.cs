using Service;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Validation;

namespace Lab03_Algorithms_SortedArraysMerging
{
    public partial class Form1 : Form
    {
        private int[] _array1;
        private int[] _array2;

        private int[] _simpleMergeResult;
        private int[] _inPlaceMergeResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int size1 = (int)arr1LenNuD.Value;
                int size2 = (int)arr2LenNuD.Value;
                int min = (int)minValNuD.Value;
                int max = (int)maxValNuD.Value;

                // Валидация
                if (!ValidationHelper.ValidateInputValues(min, max, out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Генерация
                (_array1, _array2) = ArrayGenerator.GenerateSortedArrays(size1, size2, min, max);

                _simpleMergeResult = null;
                _inPlaceMergeResult = null;

                DisplayArrays();
                ClearResults();

                MessageBox.Show($"Массивы сгенерированы:\n" +
                    $"Массив 1: {size1} элементов\n" +
                    $"Массив 2: {size2} элементов",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка генерации: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Отображение результата простого слияния
        private void DisplaySimpleMergeResult(int[] result)
        {
            simpleMergeList.Items.Clear();

            if (result != null)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    simpleMergeList.Items.Add($"[{i}] = {result[i]}");
                }

                if (simpleMergeList.Items.Count > 0)
                {
                    simpleMergeList.TopIndex = simpleMergeList.Items.Count - 1;
                }
            }
        }

        // Отображение результата слияния на месте
        private void DisplayInPlaceMergeResult(int[] result)
        {
            inPlaceMergeList.Items.Clear();

            if (result != null)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    inPlaceMergeList.Items.Add($"[{i}] = {result[i]}");
                }

                if (inPlaceMergeList.Items.Count > 0)
                {
                    inPlaceMergeList.TopIndex = inPlaceMergeList.Items.Count - 1;
                }
            }
        }


        private void DisplayArrays()
        {
            // Очищаем ListBox
            arr1List.Items.Clear();
            arr2List.Items.Clear();

            if (_array1 != null)
            {
                // Добавляем элементы первого массива

                for (int i = 0; i < _array1.Length; i++)
                {
                    arr1List.Items.Add($"[{i}] = {_array1[i]}");
                }

                // Прокручиваем вниз (к последнему элементу)
                if (arr1List.Items.Count > 0)
                {
                    arr1List.TopIndex = arr1List.Items.Count - 1;
                }

                // Обновляем информацию
                arr1InfoLb.Text = $"Массив 1 \n{_array1.Length} элементов";
            }

            if (_array2 != null)
            {
                // Добавляем элементы второго массива
                for (int i = 0; i < _array2.Length; i++)
                {
                    arr2List.Items.Add($"[{i}] = {_array2[i]}");
                }

                // Прокручиваем вниз
                if (arr2List.Items.Count > 0)
                {
                    arr2List.TopIndex = arr2List.Items.Count - 1;
                }

                // Обновляем информацию
                arr2InfoLb.Text = $"Массив 2 \n{_array2.Length} элементов";
            }
        }

        // Очистка результатов
        private void ClearResults()
        {
            simpleMergeList.Items.Clear();
            inPlaceMergeList.Items.Clear();
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {
            // Валидация
            if (!ValidationHelper.ValidateArrays(_array1, _array2, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dataGridView1.Rows.Clear();
                ClearResults();

                // Простое слияние
                var stopwatch = Stopwatch.StartNew();
                _simpleMergeResult = MergeAlgorithms.SimpleMerge(_array1, _array2, out long ops1);
                stopwatch.Stop();
                long time1 = stopwatch.ElapsedMilliseconds;
                long memory1 = MemoryCalculator.CalculateSimpleMergeMemory(_array1, _array2, _simpleMergeResult);

                // Слияние на месте
                stopwatch.Restart();
                _inPlaceMergeResult = MergeAlgorithms.InPlaceMerge(_array1, _array2, out long ops2);
                stopwatch.Stop();
                long time2 = stopwatch.ElapsedMilliseconds;
                long memory2 = MemoryCalculator.CalculateInPlaceMergeMemory(_array1, _array2, _inPlaceMergeResult);

                // Вывод результатов
                dataGridView1.Rows.Add("Простое слияние", time1, ops1, memory1);
                dataGridView1.Rows.Add("Слияние на месте", time2, ops2, memory2);

                DisplaySimpleMergeResult(_simpleMergeResult);
                DisplayInPlaceMergeResult(_inPlaceMergeResult);

                // Проверка результатов
                if (!ValidationHelper.ArraysAreEqual(_simpleMergeResult, _inPlaceMergeResult))
                {
                    MessageBox.Show("Результаты алгоритмов отличаются!",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при слиянии: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            _array1 = null;
            _array2 = null;
            _simpleMergeResult = null;
            _inPlaceMergeResult = null;
            simpleMergeList.Items.Clear();
            inPlaceMergeList.Items.Clear();

            arr1List.Items.Clear();
            arr2List.Items.Clear();
            simpleMergeList.Items.Clear();

            arr1InfoLb.Text = "Массив не сгенерирован";
            arr2InfoLb.Text = "Массив не сгенерирован";

            arr1LenNuD.Value = 10;
            arr2LenNuD.Value = 10;
            minValNuD.Value = 0;
            maxValNuD.Value = 100;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void informationBtn_Click(object sender, EventArgs e)
        {
            string helpText =
                "КАК ПОЛЬЗОВАТЬСЯ ПРОГРАММОЙ\n\n" +
                "1. Введите размер первого массива\n" +
                "2. Введите размер второго массива\n" +
                "3. Укажите минимальное и максимальное значение элементов\n" +
                "4. Нажмите кнопку «Заполнить массив»\n" +
                "5. Нажмите кнопку «Слияние» для выполнения алгоритмов\n" +
                "6. Результаты отобразятся в таблице и списках\n\n" +
                "Кнопка «Очистить» сбрасывает все данные";

            MessageBox.Show(
                helpText,
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}