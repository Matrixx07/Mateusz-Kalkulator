using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Mateusz_Kalkulator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private double ConvertToDouble(string text)
        {
            return double.Parse(text.Replace(',', '.'), CultureInfo.InvariantCulture);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "0";
        }

        private void btncomma_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            operation = "+";
            result = ConvertToDouble(textBox1.Text);
            isOperationPerformed = true;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            operation = "-";
            result = ConvertToDouble(textBox1.Text);
            isOperationPerformed = true;
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            result = ConvertToDouble(textBox1.Text);
            isOperationPerformed = true;
        }

        private void btndivider_Click(object sender, EventArgs e)
        {
            operation = "/";
            result = ConvertToDouble(textBox1.Text);
            isOperationPerformed = true;
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + ConvertToDouble(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - ConvertToDouble(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * ConvertToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (textBox1.Text != "0")
                    {
                        textBox1.Text = (result / ConvertToDouble(textBox1.Text)).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Błąd";
                    }
                    break;
                default:
                    break;
            }
            result = ConvertToDouble(textBox1.Text);
            operation = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            operation = "";
        }

        private void btndeletion_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
