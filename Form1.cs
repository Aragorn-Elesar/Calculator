using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int a, b;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = a.ToString() + "+";
            count = 1;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            int count = 2;
            textBox1.Text = a.ToString() + "-";
        }

        private void buttonmultiplication_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            int count = 3;
            textBox1.Text = a.ToString() + "*";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            int count = 4;
            textBox1.Text = a.ToString() + "/";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Calculate();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    {
                        b = a + int.Parse(textBox1.Text); 
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 2:
                    {
                        b = a - int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    }
                    case 3:
                    {
                        b = a * int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    }
                    case 4:
                    {
                        b = a / int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
