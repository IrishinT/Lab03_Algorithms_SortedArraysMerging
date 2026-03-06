using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class MemoryCalculator
    {
        private const int IntSize = sizeof(int); // 4 байта

        public static long CalculateSimpleMergeMemory(int[] arr1, int[] arr2, int[] result)
        {
            // Простое слияние: исходные массивы + новый результат
            return (arr1.Length + arr2.Length + result.Length) * IntSize;
        }

        public static long CalculateInPlaceMergeMemory(int[] arr1, int[] arr2, int[] result)
        {
            // Слияние на месте: исходные массивы + результат (по факту тоже новый массив)
            return (arr1.Length + arr2.Length + result.Length) * IntSize;
        }

        // Альтернативный вариант - только дополнительная память
        public static long CalculateExtraMemory(string algorithmType, int resultLength)
        {
            return algorithmType == "Simple"
                ? resultLength * IntSize  // Simple создает новый массив
                : resultLength * IntSize; // InPlace тоже создает новый массив в текущей реализации
        }
    }
}
