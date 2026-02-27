using System;

namespace Service
{
    public static class MergeAlgorithms
    {
        public static int[] SimpleMerge(int[] arr1, int[] arr2, out long operationCount)
        {
            operationCount = 0;
            int n = arr1.Length, m = arr2.Length;
            int[] result = new int[n + m];
            int i = 0, j = 0, k = 0;

            while (i < n && j < m)
            {
                operationCount++;
                if (arr1[i] <= arr2[j])
                {
                    result[k++] = arr1[i++];
                    operationCount++;
                }
                else
                {
                    result[k++] = arr2[j++];
                    operationCount++;
                }
            }

            while (i < n)
            {
                result[k++] = arr1[i++];
                operationCount++;
            }

            while (j < m)
            {
                result[k++] = arr2[j++];
                operationCount++;
            }

            return result;
        }

        public static int[] InPlaceMerge(int[] arr1, int[] arr2, out long operationCount)
        {
            operationCount = 0;
            int n = arr1.Length, m = arr2.Length;
            int[] merged = new int[n + m];
            Array.Copy(arr1, 0, merged, 0, n);
            Array.Copy(arr2, 0, merged, n, m);

            int left = 0, mid = n, right = n + m;
            InPlaceMergeInternal(merged, left, mid, right, ref operationCount);

            return merged;
        }

        private static void InPlaceMergeInternal(int[] array, int left, int mid, int right, ref long opCount)
        {
            int i = left;
            int j = mid;

            while (i < j && j < right)
            {
                opCount++;
                if (array[i] > array[j])
                {
                    int temp = array[j];
                    opCount++;

                    for (int k = j; k > i; k--)
                    {
                        array[k] = array[k - 1];
                        opCount++;
                    }

                    array[i] = temp;
                    opCount++;

                    i++;
                    j++;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}