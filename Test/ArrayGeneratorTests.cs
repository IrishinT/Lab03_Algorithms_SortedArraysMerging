using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class ArrayGeneratorTests
    {
        [TestMethod]
        public void GenerateSortedArrays_ValidInputs_ReturnsTwoArrays()
        {
            // Arrange
            int size1 = 5;
            int size2 = 7;
            int min = 10;
            int max = 100;

            // Act
            var (array1, array2) = ArrayGenerator.GenerateSortedArrays(size1, size2, min, max);

            // Assert
            Assert.AreEqual(size1, array1.Length);
            Assert.AreEqual(size2, array2.Length);
        }

        [TestMethod]
        public void GenerateSortedArrays_GeneratedArrays_AreSorted()
        {
            // Arrange
            int size1 = 10;
            int size2 = 15;
            int min = 1;
            int max = 1000;

            // Act
            var (array1, array2) = ArrayGenerator.GenerateSortedArrays(size1, size2, min, max);

            // Assert
            Assert.IsTrue(IsSorted(array1), "Первый массив должен быть отсортирован");
            Assert.IsTrue(IsSorted(array2), "Второй массив должен быть отсортирован");
        }

        [TestMethod]
        public void GenerateSortedArrays_GeneratedValues_AreInRange()
        {
            // Arrange
            int size1 = 8;
            int size2 = 6;
            int min = -50;
            int max = 50;

            // Act
            var (array1, array2) = ArrayGenerator.GenerateSortedArrays(size1, size2, min, max);

            // Assert
            foreach (var value in array1)
            {
                Assert.IsTrue(value >= min && value <= max,
                    $"Значение {value} выходит за диапазон [{min}, {max}]");
            }

            foreach (var value in array2)
            {
                Assert.IsTrue(value >= min && value <= max,
                    $"Значение {value} выходит за диапазон [{min}, {max}]");
            }
        }

        [TestMethod]
        public void GenerateSortedArrays_ZeroSizes_ReturnsEmptyArrays()
        {
            // Arrange
            int size1 = 0;
            int size2 = 0;
            int min = 1;
            int max = 10;

            // Act
            var (array1, array2) = ArrayGenerator.GenerateSortedArrays(size1, size2, min, max);

            // Assert
            Assert.AreEqual(0, array1.Length);
            Assert.AreEqual(0, array2.Length);
        }

        [TestMethod]
        public void GenerateSortedArrays_OneEmptyArray_ReturnsOneEmptyAndOneNonEmpty()
        {
            // Arrange
            int size1 = 0;
            int size2 = 5;
            int min = 1;
            int max = 10;

            // Act
            var (array1, array2) = ArrayGenerator.GenerateSortedArrays(size1, size2, min, max);

            // Assert
            Assert.AreEqual(0, array1.Length);
            Assert.AreEqual(size2, array2.Length);
            Assert.IsTrue(IsSorted(array2));
        }

        [TestMethod]
        public void GenerateSortedArrays_MultipleCalls_ReturnsDifferentArrays()
        {
            // Arrange
            int size1 = 10;
            int size2 = 10;
            int min = 1;
            int max = 100;

            // Act
            var (array1_first, array2_first) = ArrayGenerator.GenerateSortedArrays(size1, size2, min, max);
            var (array1_second, array2_second) = ArrayGenerator.GenerateSortedArrays(size1, size2, min, max);

            // Assert
            bool arraysAreIdentical = true;
            for (int i = 0; i < size1; i++)
            {
                if (array1_first[i] != array1_second[i])
                {
                    arraysAreIdentical = false;
                    break;
                }
            }

            // Очень маловероятно, что при случайной генерации получатся одинаковые массивы
            Assert.IsFalse(arraysAreIdentical, "При повторных вызовах должны генерироваться разные массивы");
        }

        private bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1]) return false;
            }
            return true;
        }
    }
}
