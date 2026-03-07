using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class MemoryCalculatorTests
    {
        private const int IntSize = 4; // 4 байта

        [TestMethod]
        public void CalculateSimpleMergeMemory_ValidArrays_ReturnsCorrectMemory()
        {
            // Arrange
            int[] arr1 = new int[5];
            int[] arr2 = new int[7];
            int[] result = new int[12]; // 5 + 7

            long expectedMemory = (5 + 7 + 12) * IntSize; // 24 * 4 = 96 байт

            // Act
            long actualMemory = MemoryCalculator.CalculateSimpleMergeMemory(arr1, arr2, result);

            // Assert
            Assert.AreEqual(expectedMemory, actualMemory);
        }

        [TestMethod]
        public void CalculateSimpleMergeMemory_EmptyArrays_ReturnsCorrectMemory()
        {
            // Arrange
            int[] arr1 = new int[0];
            int[] arr2 = new int[0];
            int[] result = new int[0];

            long expectedMemory = 0;

            // Act
            long actualMemory = MemoryCalculator.CalculateSimpleMergeMemory(arr1, arr2, result);

            // Assert
            Assert.AreEqual(expectedMemory, actualMemory);
        }

        [TestMethod]
        public void CalculateSimpleMergeMemory_OneEmptyArray_ReturnsCorrectMemory()
        {
            // Arrange
            int[] arr1 = new int[5];
            int[] arr2 = new int[0];
            int[] result = new int[5];

            long expectedMemory = (5 + 0 + 5) * IntSize; // 10 * 4 = 40 байт

            // Act
            long actualMemory = MemoryCalculator.CalculateSimpleMergeMemory(arr1, arr2, result);

            // Assert
            Assert.AreEqual(expectedMemory, actualMemory);
        }

        [TestMethod]
        public void CalculateInPlaceMergeMemory_ValidArrays_ReturnsCorrectMemory()
        {
            // Arrange
            int[] arr1 = new int[8];
            int[] arr2 = new int[6];
            int[] result = new int[14]; // 8 + 6

            long expectedMemory = (8 + 6 + 14) * IntSize; // 28 * 4 = 112 байт

            // Act
            long actualMemory = MemoryCalculator.CalculateInPlaceMergeMemory(arr1, arr2, result);

            // Assert
            Assert.AreEqual(expectedMemory, actualMemory);
        }

        [TestMethod]
        public void CalculateExtraMemory_SimpleAlgorithm_ReturnsResultLengthMemory()
        {
            // Arrange
            string algorithmType = "Simple";
            int resultLength = 20;
            long expectedMemory = resultLength * IntSize; // 20 * 4 = 80 байт

            // Act
            long actualMemory = MemoryCalculator.CalculateExtraMemory(algorithmType, resultLength);

            // Assert
            Assert.AreEqual(expectedMemory, actualMemory);
        }

        [TestMethod]
        public void CalculateExtraMemory_InPlaceAlgorithm_ReturnsResultLengthMemory()
        {
            // Arrange
            string algorithmType = "InPlace";
            int resultLength = 15;
            long expectedMemory = resultLength * IntSize; // 15 * 4 = 60 байт

            // Act
            long actualMemory = MemoryCalculator.CalculateExtraMemory(algorithmType, resultLength);

            // Assert
            Assert.AreEqual(expectedMemory, actualMemory);
        }

        [TestMethod]
        public void CalculateExtraMemory_ZeroLength_ReturnsZero()
        {
            // Arrange
            string algorithmType = "Simple";
            int resultLength = 0;
            long expectedMemory = 0;

            // Act
            long actualMemory = MemoryCalculator.CalculateExtraMemory(algorithmType, resultLength);

            // Assert
            Assert.AreEqual(expectedMemory, actualMemory);
        }

        [TestMethod]
        public void CalculateExtraMemory_CaseInsensitiveAlgorithmType_WorksCorrectly()
        {
            // Arrange
            string algorithmType = "SIMPLE";
            int resultLength = 10;
            long expectedMemory = resultLength * IntSize;

            // Act
            long actualMemory = MemoryCalculator.CalculateExtraMemory(algorithmType, resultLength);

            // Assert
            Assert.AreEqual(expectedMemory, actualMemory);
        }
    }
}
