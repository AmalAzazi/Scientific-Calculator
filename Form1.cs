using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{        
    public partial class Form1 : Form
    {
        double n1, n2, result;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            n2 = Convert.ToDouble (textBox2.Text);
            result = n1 + n2;
            textBox3.Text = result.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            n2 = Convert.ToDouble (textBox2.Text);
            result = n1 - n2;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            n2 = Convert.ToDouble (textBox2.Text);
            result = n1 * n2;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            n2 = Convert.ToDouble (textBox2.Text);
            result = n1 / n2;
            textBox3.Text = result.ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble (textBox1.Text);
            result = System.Math.Sqrt(sqrt);
            textBox3.Text = result.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            n2 = Convert.ToDouble (textBox2.Text);
            result = System.Math.Pow(n1, n2);
            textBox3.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = n1 * n1;
            textBox3.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble (textBox2.Text);
            result = System.Math.Pow(n1, 1 / n2);
            textBox3.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Sin (n1);
            textBox3.Text = result.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Cos(n1);
            textBox3.Text = result.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Tan (n1);
            textBox3.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Sinh (n1);
            textBox3.Text = result.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Cosh (n1);
            textBox3.Text = result.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Tanh (n1);
            textBox3.Text = result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Abs(n1);
            textBox3.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = 1 / n1;
            textBox3.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = n1 / 100;
            textBox3.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int result = 1;
            n1 = Convert.ToDouble (textBox1.Text);
            for (int i = 2; i <= n1; i++)
            {
                result = result * i;
            }
            textBox3.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Pow(10, n1);
            textBox3.Text = result.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Log10(n1);
            textBox3.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Asin(n1);
            textBox3.Text = result.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Acos (n1);
            textBox3.Text = result.ToString();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (textBox1.Text);
            result = System.Math.Atan (n1);
            textBox3.Text = result.ToString();
        }

        
       
    }
}
