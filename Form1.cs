using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operatorPerform = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }else
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue != 0)
            {
                button18.PerformClick();
                operatorPerform = button.Text;
                label1.Text = resultValue + " " + operatorPerform;
                isOperationPerformed = true;
            }
            else
            {
                operatorPerform = button.Text;
                resultValue = double.Parse(textBox1.Text);
                label1.Text = resultValue + " " + operatorPerform;
                isOperationPerformed = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operatorPerform)
            {
                case "+":
                    textBox1.Text = (resultValue + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBox1.Text);
            label1.Text = "";
        }
    }
}
