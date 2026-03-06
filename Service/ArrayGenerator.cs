using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class ArrayGenerator
    {
        private static readonly Random _random = new Random();

        public static (int[] array1, int[] array2) GenerateSortedArrays(int size1, int size2, int min, int max)
        {
            var array1 = GenerateSortedArray(size1, min, max);
            var array2 = GenerateSortedArray(size2, min, max);

            return (array1, array2);
        }

        private static int[] GenerateSortedArray(int size, int min, int max)
        {
            var array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = _random.Next(min, max + 1);
            }

            Array.Sort(array);
            return array;
        }
    }
}
