using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        Double res = 0;
        String op = "";
        bool isopperformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (isopperformed)
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            isopperformed = false;
        }

        private void OPERATIONS(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            op = button.Text;
            res = Double.Parse(textBox1.Text);
            label1.Text = res + " " + op;
            isopperformed = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    textBox1.Text = (res + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (res - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (res * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (res / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
