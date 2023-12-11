using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_UAS.ALGO
{
    public partial class Login : Form
    {

        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader reader;

        public Login()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                

                textBox1.ForeColor = Color.White;
                panel4.Visible = false;
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                

                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*'; // convert text to *
                panel7.Visible = false;
            }
            catch { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andri\OneDrive\Documents\DB_Login.mdf;Integrated Security=True");
            conn.Open();

            //if (textBox1.Text == "Enter Username")
            //{
            //    panel4.Visible = true;
            //    textBox1.Focus();
            //    return;
            //}


            //if (textBox2.Text == "Password")
            //{
            //    panel7.Visible = true;
            //    textBox2.PasswordChar = '*'; // convert text to *
            //    textBox2.Focus();
            //    return;
            //}

            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                cmd = new SqlCommand("SELECT * FROM Tb_Login WHERE username= '" + textBox1.Text + "' and password= '" + textBox2.Text + "' ", conn);
                reader = cmd.ExecuteReader();
                panel4.Visible = true;
                textBox1.Focus();
                
                if (reader.Read())
                {
                    reader.Close();
                    this.Hide();
                    GUI menuUtama = new GUI();
                    menuUtama.Show();
                }
            }

            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andri\OneDrive\Documents\DB_Login.mdf;Integrated Security=True");
                conn.Open();

                if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
                {
                    cmd = new SqlCommand("SELECT * FROM Tb_Login WHERE username= '" + textBox1.Text + "' and password= '" + textBox2.Text + "' ", conn);
                    reader = cmd.ExecuteReader();
                    panel4.Visible = true;
                    textBox1.Focus();

                    if (reader.Read())
                    {
                        reader.Close();
                        this.Hide();
                        GUI menuUtama = new GUI();
                        menuUtama.Show();
                    }
                }
            }

        }
    }
}


