using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace T_UAS.ALGO
{

    struct Mahasiswa
    {
        public string Nama { get; set; }
        public int Umur { get; set; }
        public string Jurusan { get; set; }

    }

    public partial class BinSeqSearch : Form
    {
       
        String pilih;
        List<Mahasiswa> mahasiswaList = new List<Mahasiswa>();

        public BinSeqSearch()
        {
           
            InitializeComponent();
            TBSearch.ReadOnly = true;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pilih = comboBox1.SelectedItem.ToString();
            TBSearch.Text = "";
            D1Name.Text = "";
            D2Name.Text = "";
            D1Umur.Text = "";
            D2Umur.Text = "";
            D1Jurusan.Text = "";
            D2Jurusan.Text = "";

            if (pilih == "pilih" || pilih== "Input Data")
            {                
                TBSearch.ReadOnly = true;
            }
            else
            {
                TBSearch.ReadOnly=false;
            }

        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void D1Name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void D1Umur_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void D1Jurusan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pilih == "Input Data")
            {
                int umur;
                if (int.TryParse(D1Umur.Text, out umur))
                {
                    Mahasiswa mahasiswa1 = new Mahasiswa
                    {
                        Nama = D1Name.Text,
                        Umur = umur,
                        Jurusan = D1Jurusan.Text,
                    };

                    Mahasiswa mahasiswa2 = new Mahasiswa
                    {
                        Nama = D2Name.Text,
                        Umur = umur,
                        Jurusan = D2Jurusan.Text
                    };

                    // Lakukan sesuatu dengan mahasiswa (misalnya, simpan ke dalam list atau database)
                    mahasiswaList.Add(mahasiswa1);
                    mahasiswaList.Add(mahasiswa2);

                    MessageBox.Show("Data mahasiswa berhasil ditambahkan.");

                    D1Name.Clear();
                    D1Umur.Clear();
                    D1Jurusan.Clear();

                    D2Name.Clear();
                    D2Umur.Clear();
                    D2Jurusan.Clear();
                }
                else
                {
                    MessageBox.Show("Umur harus berupa angka.");
                }
            }
            else if (pilih == "Binary Search")
            {
                string pencarian = TBSearch.Text; // ganti ini sesuai dengan kolom yang ingin dicari
                bool ditemukan = BinarySearch(mahasiswaList, pencarian);
                MessageBox.Show(ditemukan ? $"Data {pilih}...\n\nMencari data...\nMencari data...\n\nData mahasiswa ditemukan '{pencarian}' " : "Tambahkan data mahasiswa terlebih dahulu.");

                D1Name.Clear();
            }
            else if (pilih == "Sequential Search")
            {
                string pencarian = TBSearch.Text;
                bool ditemukan = SequentialSearch(mahasiswaList, pencarian);
                MessageBox.Show(ditemukan ? $"Data {pilih}...\n\nMencari data...\nMencari data...\n\nData mahasiswa ditemukan '{pencarian}' " : "Tambahkan data mahasiswa terlebih dahulu.");

                D1Name.Clear();
            }
        }

        private bool BinarySearch(List<Mahasiswa> list, string nama)
        {
            list.Sort((x, y) => x.Nama.CompareTo(y.Nama));
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                int result = list[middle].Nama.CompareTo(nama);

                if (result == 0)
                    return true; 
                else if (result < 0)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return false; 
        }

        private bool SequentialSearch(List<Mahasiswa> list, string nama)
        {

            foreach (var mahasiswa in list)
            {
                if (mahasiswa.Nama.Equals(nama))
                    return true; 
            }

            return false; 
        }




        public void BinSeqSearch_Load(object sender, EventArgs e)
        {

        }

        private void D2Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void D2Umur_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void D2Jurusan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BinSeqSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI menuUtama = new GUI();
            menuUtama.Show();
            //In case windows is trying to shut down, don't hold the process up
            //if (e.CloseReason == CloseReason.WindowsShutDown) 
            //    return;

            
        }
    }
}
