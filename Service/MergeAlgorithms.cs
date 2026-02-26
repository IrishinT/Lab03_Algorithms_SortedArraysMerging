using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				operationCount++; // сравнение
				if (arr1[i] <= arr2[j])
				{
					result[k++] = arr1[i++];
					operationCount++; // присваивание
				}
				else
				{
					result[k++] = arr2[j++];
					operationCount++; // присваивание
				}
			}

			while (i < n)
			{
				result[k++] = arr1[i++];
				operationCount++; // присваивание
			}

			while (j < m)
			{
				result[k++] = arr2[j++];
				operationCount++; // присваивание
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

			// Границы двух подмассивов внутри merged
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
				opCount++; // сравнение array[i] и array[j]
				if (array[i] > array[j])
				{
					// Вставляем array[j] в позицию i, сдвигая блок array[i..j-1] вправо
					int temp = array[j];
					opCount++; // присваивание temp

					// Сдвиг
					for (int k = j; k > i; k--)
					{
						array[k] = array[k - 1];
						opCount++; // присваивание при сдвиге
					}

					array[i] = temp;
					opCount++; // присваивание array[i]

					i++;
					j++; // так как j сместился вправо
				}
				else
				{
					i++;
				}
			}
		}

	}
}
