using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_UAS.ALGO
{
    public partial class Insert_Sort : Form
    {
        private int[] arrayToSort;

        public Insert_Sort()
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
            InsertionSort(arrayToSort);
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

        private void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;
            }
        }

        private void DisplayArray()
        {
            textBoxArray.Text = string.Join(", ", arrayToSort);
        }

        private void Insert_Sort_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI menuUtama = new GUI();
            menuUtama.Show();
        }
    }
}
