using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System;

namespace Tests
{
    [TestClass]
    public class MergeAlgorithmsTests
    {
        // ========== SIMPLE MERGE TESTS WITH DATAROW ==========

        [DataTestMethod]
        [DataRow(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { -5, -3, 0 }, new int[] { -4, -2, 1 }, new int[] { -5, -4, -3, -2, 0, 1 })]
        [DataRow(new int[] { 1, 2, 2, 3 }, new int[] { 2, 3, 4 }, new int[] { 1, 2, 2, 2, 3, 3, 4 })]
        [DataRow(new int[] { 5 }, new int[] { 3 }, new int[] { 3, 5 })]
        [DataRow(new int[] { int.MinValue, 0 }, new int[] { 100, int.MaxValue }, new int[] { int.MinValue, 0, 100, int.MaxValue })]
        public void SimpleMerge_VariousInputs_ReturnsCorrectMergedArray(int[] arr1, int[] arr2, int[] expected)
        {
            int[] result = MergeAlgorithms.SimpleMerge(arr1, arr2, out long ops);

            CollectionAssert.AreEqual(expected, result);
            Assert.IsTrue(ops > 0);
        }

        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { }, new int[] { }, new int[] { })]
        public void SimpleMerge_EmptyArrays_ReturnsCorrectResult(int[] arr1, int[] arr2, int[] expected)
        {
            int[] result = MergeAlgorithms.SimpleMerge(arr1, arr2, out long ops);

            CollectionAssert.AreEqual(expected, result);

            if (arr1.Length == 0 && arr2.Length == 0)
                Assert.AreEqual(0, ops);
        }

        // ========== IN PLACE MERGE TESTS WITH DATAROW ==========

        [DataTestMethod]
        [DataRow(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { -5, -3, 0 }, new int[] { -4, -2, 1 }, new int[] { -5, -4, -3, -2, 0, 1 })]
        [DataRow(new int[] { 1, 2, 2, 3 }, new int[] { 2, 3, 4 }, new int[] { 1, 2, 2, 2, 3, 3, 4 })]
        [DataRow(new int[] { 5 }, new int[] { 3 }, new int[] { 3, 5 })]
        [DataRow(new int[] { int.MinValue, 0 }, new int[] { 100, int.MaxValue }, new int[] { int.MinValue, 0, 100, int.MaxValue })]
        public void InPlaceMerge_VariousInputs_ReturnsCorrectMergedArray(int[] arr1, int[] arr2, int[] expected)
        {
            int[] result = MergeAlgorithms.InPlaceMerge(arr1, arr2, out long ops);

            CollectionAssert.AreEqual(expected, result);
            Assert.IsTrue(ops > 0);
        }

        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { }, new int[] { }, new int[] { })]
        public void InPlaceMerge_EmptyArrays_ReturnsCorrectResult(int[] arr1, int[] arr2, int[] expected)
        {
            int[] result = MergeAlgorithms.InPlaceMerge(arr1, arr2, out long ops);

            CollectionAssert.AreEqual(expected, result);

            if (arr1.Length == 0 && arr2.Length == 0)
                Assert.AreEqual(0, ops);
        }

        // ========== COMPARISON TESTS ==========

        [DataTestMethod]
        [DataRow(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 })]
        [DataRow(new int[] { -5, -3, 0 }, new int[] { -4, -2, 1 })]
        [DataRow(new int[] { 1, 2, 2, 3 }, new int[] { 2, 3, 4 })]
        [DataRow(new int[] { 5 }, new int[] { 3 })]
        [DataRow(new int[] { }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { })]
        [DataRow(new int[] { }, new int[] { })]
        public void CompareAlgorithms_BothProduceSameResult(int[] arr1, int[] arr2)
        {
            int[] result1 = MergeAlgorithms.SimpleMerge(arr1, arr2, out long ops1);
            int[] result2 = MergeAlgorithms.InPlaceMerge(arr1, arr2, out long ops2);

            CollectionAssert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void SimpleMerge_LargeArrays_CompletesWithoutError()
        {
            int[] arr1 = new int[5000];
            int[] arr2 = new int[5000];

            for (int i = 0; i < 5000; i++)
            {
                arr1[i] = i * 2;
                arr2[i] = i * 2 + 1;
            }

            int[] result = MergeAlgorithms.SimpleMerge(arr1, arr2, out long ops);

            Assert.AreEqual(10000, result.Length);
            Assert.IsTrue(ops > 0);
        }

        [TestMethod]
        public void InPlaceMerge_LargeArrays_CompletesWithoutError()
        {
            int[] arr1 = new int[5000];
            int[] arr2 = new int[5000];

            for (int i = 0; i < 5000; i++)
            {
                arr1[i] = i * 2;
                arr2[i] = i * 2 + 1;
            }

            int[] result = MergeAlgorithms.InPlaceMerge(arr1, arr2, out long ops);

            Assert.AreEqual(10000, result.Length);
            Assert.IsTrue(ops > 0);
        }


    }


}