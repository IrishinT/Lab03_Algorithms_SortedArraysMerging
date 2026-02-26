using System.Diagnostics;
using Service;

namespace Lab03_Algorithms_SortedArraysMerging
{
    public partial class Form1 : Form
    {
        // Поля для хранения массивов
        private int[] _array1;
        private int[] _array2;


        public Form1()
        {
            InitializeComponent();
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {

            if (_array1 == null || _array2 == null)
            {
                MessageBox.Show("Сначала сгенерируйте массивы!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dataGridView1.Rows.Clear();

                // Замер SimpleMerge
                var stopwatch = Stopwatch.StartNew();
                var result1 = MergeAlgorithms.SimpleMerge(_array1, _array2, out long ops1);
                stopwatch.Stop();
                long time1 = stopwatch.ElapsedMilliseconds;
                long memory1 = (_array1.Length + _array2.Length + result1.Length) * sizeof(int);

                // Замер InPlaceMerge
                stopwatch.Restart();
                var result2 = MergeAlgorithms.InPlaceMerge(_array1, _array2, out long ops2);
                stopwatch.Stop();
                long time2 = stopwatch.ElapsedMilliseconds;
                long memory2 = (_array1.Length + _array2.Length + result2.Length) * sizeof(int);

                // Добавление результатов в таблицу
                dataGridView1.Rows.Add("Простое слияние", time1, ops1, memory1);
                dataGridView1.Rows.Add("Слияние на месте", time2, ops2, memory2);

                // Проверка корректности результатов
                if (!AreArraysEqual(result1, result2))
                {
                    MessageBox.Show("ВНИМАНИЕ: Результаты алгоритмов отличаются!",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при слиянии: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int size1 = (int)arr1LenNuD.Value;
                int size2 = (int)arr2LenNuD.Value;
                int min = (int)minValNuD.Value;
                int max = (int)maxValNuD.Value;

                if (min >= max)
                {
                    MessageBox.Show("Минимальное значение должно быть меньше максимального!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Random rand = new Random();

                // Генерация первого отсортированного массива
                _array1 = new int[size1];
                for (int i = 0; i < size1; i++)
                {
                    _array1[i] = rand.Next(min, max + 1);
                }
                Array.Sort(_array1);

                // Генерация второго отсортированного массива
                _array2 = new int[size2];
                for (int i = 0; i < size2; i++)
                {
                    _array2[i] = rand.Next(min, max + 1);
                }
                Array.Sort(_array2);

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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            _array1 = null;
            _array2 = null;
            dataGridView1.Rows.Clear();

            arr1LenNuD.Value = 10;
            arr2LenNuD.Value = 10;
            minValNuD.Value = 0;
            maxValNuD.Value = 100;

            MessageBox.Show("Все данные очищены", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool AreArraysEqual(int[] arr1, int[] arr2)
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
