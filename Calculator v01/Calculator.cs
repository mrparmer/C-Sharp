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
    public partial class Calculator : Form
    {
        string input    = string.Empty;     //string storing user input
        string operand1 = string.Empty;     //string storing first operand
        string operand2 = string.Empty;     //string storing second operand
        char              operation;        //char for operation
        double result   = 0.0;              //calculated result

        public Calculator()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            answer.Text = answer.Text + b.Text;
        }
        /*
        private void one_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "1";
            this.entry.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "2";
            this.entry.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "3";
            this.entry.Text += input;
        }
        
        private void four_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "4";
            this.entry.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "5";
            this.entry.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "6";
            this.entry.Text += input;
        }
        
        private void seven_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "7";
            this.entry.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "8";
            this.entry.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "9";
            this.entry.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += "0";
            this.entry.Text += input;
        }

        private void point_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            input += ".";
            this.entry.Text += input;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.entry.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        
        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '^';
            input = string.Empty;
        }
        */
        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.entry.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand1 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                entry.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                entry.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    entry.Text = result.ToString();
                }
                else
                {
                    entry.Text = "DIV/Zero";
                }

            }
            else if (operation == '^')
            {
                result = Math.Pow(num1, num2);
                entry.Text = result.ToString();

            }
            else if (operation == '*')
            {
                result = num1 * num2;
                entry.Text = result.ToString();
            }
            
        } 
    }
}
