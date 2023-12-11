using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace T_UAS.ALGO
{

    public partial class Calculator2 : Form
    {

        public Calculator2()
        {
            InitializeComponent();
        }
        public string lastoperat;
        public double lastNumber;

        public Boolean clearLcd;
        public Boolean overOpra;
        public Boolean twoOperand;
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

            button22.Click += btnSe;
            button23.Click += btnSe;
            button24.Click += btnSe;
            button19.Click += btnSe;
            button18.Click += btnSe;
            button17.Click += btnSe;
            button14.Click += btnSe;
            button13.Click += btnSe;
            button12.Click += btnSe;
            button20.Click += btnSe;
            button15.Click += btnSe;
            // button15.Paint += new PaintEventHandler(this.Button_Paint);
            button7.Click += Opra;
            button8.Click += Opra;
            button9.Click += Opra;
            button10.Click += Opra;
            button3.Click += Opra;
            button32.Click += Opra;
            button27.Click += Opra;

            button25.Click += TwoOpra;
            button35.Click += TwoOpra;
            button26.Click += TwoOpra;
            button2.Click += TwoOpra;
            button4.Click += TwoOpra;
            button30.Click += TwoOpra;
            button29.Click += TwoOpra;
            button33.Click += TwoOpra;
            button34.Click += TwoOpra;
            button28.Click += TwoOpra;
            button31.Click += TwoOpra;
            button5.Click += TwoOpra;
            button36.Click += TwoOpra;


        }

        private void button24_Click(object sender, EventArgs e)
        {

        }
        private void btnSe(object sender, EventArgs e)
        {
            Button btnNum = sender as Button;
            overOpra = false;

            string[] txtLin = txtRe.Lines;
            String oldText = txtRe.Lines[1];
            if (twoOperand)
            {
                reset();
                string[] oldtxtMini2 = txtRe.Lines;
                oldtxtMini2[1] = btnNum.Text;
                txtRe.Lines = oldtxtMini2;
                twoOperand = false;
                return;
            }
            if (clearLcd)
            {

                txtLin[1] = "" + btnNum.Text;
                txtRe.Lines = txtLin;
                clearLcd = false;
                return;
            }
            if (btnNum.Text.Equals("/"))
            {
                if (!oldText.Contains("/"))
                {
                    txtLin[1] = oldText + btnNum.Text;
                    txtRe.Lines = txtLin;
                    return;
                }
                return;
            }
            if (oldText.Equals("0"))
            {
                txtLin[1] = btnNum.Text;
                txtRe.Lines = txtLin;

            }
            else
            {
                if (oldText.Length < 10)
                {
                    txtLin[1] = oldText + "" + btnNum.Text;
                    txtRe.Lines = txtLin;
                }
            }
        }
        private void Opra(object sender, EventArgs e)
        {
            twoOperand = false;
            Double lNumber = Convert.ToDouble(txtRe.Lines[1]);
            //String lastOperator = oprat;
            Button btn = sender as Button;
            String operat = btn.Text;
            clearLcd = true;

            if (overOpra)
            {
                lastoperat = operat;
                string[] oldtxtMini = txtRe.Lines;
                string oldmini = txtRe.Lines[0];
                string oldCrop = oldmini.Substring(0, oldmini.Length - 1);
                oldtxtMini[0] = oldCrop + operat;
                txtRe.Lines = oldtxtMini;
                return;
            }

            string[] oldtxtMini2 = txtRe.Lines;
            String oldmini2 = txtRe.Lines[0];
            oldtxtMini2[0] = oldmini2 + lNumber + operat;
            txtRe.Lines = oldtxtMini2;
            overOpra = true;
            if (lastoperat == null)
            {
                lastNumber = lNumber;
            }
            else
            {
                final();
                /*double result = 0;
                if (lastoperat.Equals("/"))
                {
                    result = lastNumber / lNumber;
                }
                else if (lastoperat.Equals("*"))
                {
                    result = lastNumber * lNumber;
                }
                else if (lastoperat.Equals("-"))
                {
                    result = lastNumber - lNumber;
                }
                else if (lastoperat.Equals("+"))
                {
                    result = lastNumber + lNumber;

                }
                else if (lastoperat.Equals("Mod"))
                {
                    
                    result = lastNumber % lNumber;

                }
                else if (lastoperat.Equals("x^y"))
                {

                      result = Math.Pow( lastNumber,lNumber);

                }
                else if (lastoperat.Equals("x^1/y"))
                {

                    result = Math.Pow(lastNumber, (1 / lNumber));

                }


                string[] txtLin = txtRe.Lines;
                txtLin[1] = "" + result;
                txtRe.Lines = txtLin;
                lastNumber = result;*/


            }

            lastoperat = operat;



        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clearLcd == false)
            {
                Double lNumber = Convert.ToDouble(txtRe.Lines[1]);
                if (txtRe.Lines[1] != null && lastoperat != null)
                {
                    final();

                }
                reset();
                clearLcd = true;
            }

        }
        public void final()
        {
            Double lNumber = Convert.ToDouble(txtRe.Lines[1]);
            double result = 0;

            if (lastoperat.Equals("/"))
            {
                result = lastNumber / lNumber;
            }
            else if (lastoperat.Equals("*"))
            {
                result = lastNumber * lNumber;
            }
            else if (lastoperat.Equals("-"))
            {
                result = lastNumber - lNumber;
            }
            else if (lastoperat.Equals("+"))
            {
                result = lastNumber + lNumber;

            }
            else if (lastoperat.Equals("+"))
            {
                result = lastNumber + lNumber;

            }
            else if (lastoperat.Equals("Mod"))
            {

                result = lastNumber % lNumber;

            }
            else if (lastoperat.Equals("x^y"))
            {

                result = Math.Pow(lastNumber, lNumber);

            }
            else if (lastoperat.Equals("x^1/y"))
            {

                result = Math.Pow(lastNumber, (1 / lNumber));

            }
            string[] txtSqr = txtRe.Lines;

            string[] txtLin = txtRe.Lines;
            txtLin[1] = "" + result;
            txtRe.Lines = txtLin;
            lastNumber = result;

        }
        public void reset()
        {
            string[] oldtxtMini2 = txtRe.Lines;
            oldtxtMini2[0] = "";
            txtRe.Lines = oldtxtMini2;
            lastoperat = null;
            // oprat = null;
            clearLcd = false;
            overOpra = false;
            twoOperand = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reset();
            string[] oldtxtMini2 = txtRe.Lines;
            oldtxtMini2[1] = "0";
            txtRe.Lines = oldtxtMini2;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string[] oldtxtMini2 = txtRe.Lines;
            string oldCrop = txtRe.Lines[1];
            if (!oldCrop.Equals("0"))
            {
                oldtxtMini2[1] = Convert.ToString((Convert.ToDouble(oldCrop) * (-1)));
                txtRe.Lines = oldtxtMini2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button25_Click(object sender, EventArgs e)
        {


        }


        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void TwoOpra(object sender, EventArgs e)
        {
            twoOperand = true;
            Button button = sender as Button;
            string TOO = button.Text;
            string[] txtSqr = txtRe.Lines;
            double result = 0;
            string mini = "";



            if (TOO.Equals("sin"))
            {
                result = Math.Sin(RadianToDegree(Convert.ToDouble(txtRe.Lines[1])));
                mini = txtSqr[0] + "Sin(" + txtRe.Lines[1] + ")";
            }
            else if (TOO.Equals("cos"))
            {
                result = Math.Cos(RadianToDegree(Convert.ToDouble(txtRe.Lines[1])));
                mini = txtSqr[0] + "Cos(" + txtRe.Lines[1] + ")";
            }
            else if (TOO.Equals("tan"))
            {
                result = Math.Tan(RadianToDegree(Convert.ToDouble(txtRe.Lines[1])));
                mini = txtSqr[0] + "tan(" + txtRe.Lines[1] + ")";
            }
            else if (TOO.Equals("Exp"))
            {
                result = Math.Exp(Convert.ToDouble(txtRe.Lines[1]));
                mini = txtSqr[0] + "Exp(" + txtRe.Lines[1] + ")";
            }
            else if (TOO.Equals("ln"))
            {
                result = Math.Log(Convert.ToDouble(txtRe.Lines[1]));
                mini = txtSqr[0] + "Ln(" + txtRe.Lines[1] + ")";
            }
            else if (TOO.Equals("10^x"))
            {
                result = Math.Pow(10, Convert.ToDouble(txtRe.Lines[1]));
                mini = txtSqr[0] + "10^(" + txtRe.Lines[1] + ")";
            }
            else if (TOO.Equals("x^3"))
            {
                result = Math.Pow(((Convert.ToDouble(txtRe.Lines[1]))), 3);
                mini = txtSqr[0] + "(" + txtRe.Lines[1] + ")^3";
            }
            else if (TOO.Equals("x^2"))
            {
                result = Math.Pow(Convert.ToDouble(txtRe.Lines[1]), 2);
                mini = txtSqr[0] + "(" + txtRe.Lines[1] + ")^2";
            }
            else if (TOO.Equals("x^1/3"))
            {
                result = Math.Pow(((Convert.ToDouble(txtRe.Lines[1]))), 0.3333333333);
                mini = txtSqr[0] + "(" + txtRe.Lines[1] + ")^2";
            }
            else if (TOO.Equals("log"))
            {
                result = Math.Log(Convert.ToDouble(txtRe.Lines[1]), 10); ;
                mini = txtSqr[0] + "log(" + txtRe.Lines[1] + ")";
            }
            else if (TOO.Equals("Sqrt"))
            {

                if (!txtRe.Lines[1].Equals("0") && !txtRe.Lines[1].Contains("-"))
                {

                    result = Math.Sqrt((Convert.ToDouble(txtRe.Lines[1])));
                    mini = txtSqr[0] + "Sqrt(" + txtRe.Lines[1] + ")";


                }
                else
                {
                    MessageBox.Show("ll");
                    reset();
                    string[] oldtxtMini2 = txtRe.Lines;
                    oldtxtMini2[1] = "0";
                    txtRe.Lines = oldtxtMini2;
                }

            }
            else if (TOO.Equals("1/x"))
            {


                if (!txtRe.Lines[1].Equals("0"))
                {

                    result = 1 / ((Convert.ToDouble(txtRe.Lines[1])));
                    mini = txtSqr[0] + "1/" + txtRe.Lines[1];
                }
                else
                {
                    reset();
                    string[] oldtxtMini2 = txtRe.Lines;
                    oldtxtMini2[1] = "0";
                    txtRe.Lines = oldtxtMini2;
                }
            }
            else if (TOO.Equals("n!"))
            {
                int fact = 1;
                for (int c = 1; c <= ((Convert.ToDouble(txtRe.Lines[1]))); c++)
                    fact = fact * c;
                result = fact;
            }




            txtSqr[0] = mini;
            txtSqr[1] = "" + result;
            overOpra = false;
            txtRe.Lines = txtSqr;


        }
        private double RadianToDegree(double angle)
        {
            return angle * (Math.PI / 180.0);
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            string[] oldtxtMini = txtRe.Lines;
            //MessageBox.Show("" + oldtxtMini[1].Length);
            if (clearLcd == false && twoOperand == false)
            {
                if (oldtxtMini[1].Length <= 1)
                {
                    oldtxtMini[1] = "0";
                    txtRe.Lines = oldtxtMini;

                }
                else
                {
                    string oldmini = txtRe.Lines[1];
                    string oldCrop = oldmini.Substring(0, oldmini.Length - 1);
                    oldtxtMini[1] = oldCrop;
                    txtRe.Lines = oldtxtMini;
                }


            }
        }

        private void Calculator2_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI menuUtama = new GUI();
            menuUtama.Show();
        }
    }
}