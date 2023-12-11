using System;
using System.Windows.Forms;
using T_UAS.ALGO;

namespace T_UAS.ALGO
{
    public partial class Shell_Sort : Form
    {
        private int[] arrayToSort;

        public Shell_Sort()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateRandomArray();
            DisplayArray();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            ShellSort(arrayToSort);
            DisplayArray();
        }

        private void GenerateRandomArray()
        {
            Random random = new Random();
            arrayToSort = new int[10]; // Ganti ukuran array sesuai kebutuhan

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                arrayToSort[i] = random.Next(1, 100); // Angka acak antara 1 dan 100
            }
        }

        private void ShellSort(int[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }

                gap /= 2;
            }
        }

        private void DisplayArray()
        {
            textBoxArray.Text = string.Join(", ", arrayToSort);
        }

        private void Shell_Sort_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI menuUtama = new GUI();
            menuUtama.Show();
        }
    }
}
