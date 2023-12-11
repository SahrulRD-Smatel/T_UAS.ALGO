using System;
using System.Windows.Forms;

namespace T_UAS.ALGO
{
    public partial class ArrayForm : Form
    {
        private int[] numbers = new int[5]; // Ganti ukuran array sesuai kebutuhan

        public ArrayForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;

            if (int.TryParse(inputText, out int number))
            {
                AddNumberToArray(number);
                DisplayArray();
            }
            else
            {
                MessageBox.Show("Input harus berupa angka.");
            }

            textBoxInput.Clear();
        }

        private void AddNumberToArray(int number)
        {
            int index = Array.IndexOf(numbers, 0);

            if (index == -1)
            {
                MessageBox.Show("Array sudah penuh.");
                return;
            }

            numbers[index] = number;
        }

        private void DisplayArray()
        {
            textBoxOutput.Text = string.Join(", ", numbers);
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DisplayArray telah ditampilkan");
            DisplayArray();
        }

        private void ArrayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI menuUtama = new GUI();
            menuUtama.Show();
        }
    }
}
