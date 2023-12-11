using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_UAS.ALGO
{


    public partial class GUI : Form
    {

        public GUI()
        {
            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayForm arrayForm = new ArrayForm();
            arrayForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Calculator2
            Calculator2 calculator2Form = new Calculator2();

            // Menampilkan Calculator2
            calculator2Form.Show();

            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menghitung_Luas hitungKL = new Menghitung_Luas();

            hitungKL.Show();

            this.Hide();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Shell_Sort shell_Sort = new Shell_Sort();
            shell_Sort.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BinSeqSearch BSsearch = new BinSeqSearch();
            BSsearch.Show();


            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Insert_Sort insert_Sort = new Insert_Sort();
            insert_Sort.Show();
            this.Hide();
        }

        
    }
}
