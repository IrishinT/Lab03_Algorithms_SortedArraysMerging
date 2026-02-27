namespace Validation
{
    public static class ValidationHelper
    {
        public static bool ValidateArrays(int[] arr1, int[] arr2, out string errorMessage)
        {
            errorMessage = null;

            if (arr1 == null || arr2 == null)
            {
                errorMessage = "Сначала сгенерируйте массивы!";
                return false;
            }

            if (!IsSorted(arr1))
            {
                errorMessage = "Первый массив не отсортирован!";
                return false;
            }

            if (!IsSorted(arr2))
            {
                errorMessage = "Второй массив не отсортирован!";
                return false;
            }

            return true;
        }

        public static bool ValidateInputValues(int min, int max, out string errorMessage)
        {
            errorMessage = null;

            if (min >= max)
            {
                errorMessage = "Минимальное значение должно быть меньше максимального!";
                return false;
            }

            return true;
        }

        private static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1]) return false;
            }
            return true;
        }

        public static bool ArraysAreEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length) return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }

            return true;
        }
    }
}
