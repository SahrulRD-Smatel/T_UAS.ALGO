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
    public partial class Menghitung_Luas : Form
    {
        String pilih;
        Decimal panjang, lebar, hasil;
        public Menghitung_Luas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pilih = comboBox1.SelectedItem.ToString();
        }
        
        private void Menghitung_Luas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(textBox1.Text, out panjang))
            {
                // Lakukan sesuatu jika nilai dapat di-parse ke Decimal
            }
            else
            {
                // Tindakan jika input tidak valid (misalnya, tidak dapat di-parse ke Decimal)
                MessageBox.Show("Masukkan nilai panjang yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menghitung_Luas_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI menuUtama = new GUI();
            menuUtama.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(textBox2.Text, out lebar))
            {
                // Lakukan sesuatu jika nilai dapat di-parse ke Decimal
            }
            else
            {
                // Tindakan jika input tidak valid (misalnya, tidak dapat di-parse ke Decimal)
                MessageBox.Show("Masukkan nilai lebar yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pilih == "Luas")
            {
                hasil = panjang * lebar;
            }
            else if (pilih == "Keliling")
            {
                hasil = (2 * panjang) + (2 * lebar);
            }
            else if (pilih == "Panjang Diagonal")
            {
                // Debugging messages to check the values
                MessageBox.Show($"Panjang: {panjang}, Lebar: {lebar}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Check if panjang and lebar are greater than zero before calculating diagonal
                if (panjang > 0 && lebar > 0)
                {
                    hasil = (decimal)Math.Sqrt((double)(panjang * panjang + lebar * lebar));
                }
                else
                {
                    MessageBox.Show("Masukkan nilai panjang dan lebar yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Kembalikan agar tidak menampilkan MessageBox hasil di bawah
                }
            }

            MessageBox.Show($"Jadi {pilih} Persegi Panjangnya adalah {hasil}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
