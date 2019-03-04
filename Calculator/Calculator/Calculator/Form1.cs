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

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            operation = '+';
            input = string.Empty;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button oneBtn = (Button)sender;
            resultsBox.Text = resultsBox.Text + oneBtn;
        }

        private void ResultsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "1";
            this.resultsBox.Text += input;

        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "2";
            this.resultsBox.Text += input;
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "3";
            this.resultsBox.Text += input;
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "4";
            this.resultsBox.Text += input;
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "5";
            this.resultsBox.Text += input;
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "6";
            this.resultsBox.Text += input;
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "7";
            this.resultsBox.Text += input;
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "8";
            this.resultsBox.Text += input;
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "9";
            this.resultsBox.Text += input;
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            operation = '%';
            this.resultsBox.Text += input;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            operation = '/';
            this.resultsBox.Text += input;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            operation = '*';
            this.resultsBox.Text += input;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            operation = '-';
            this.resultsBox.Text += input;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += ".";
            this.resultsBox.Text += input;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "0";
            this.resultsBox.Text += input;
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.resultsBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand1 = string.Empty;

            if ( operation == '+')
            {
                result = num1 + num2;
                resultsBox.Text = result.ToString();
            }
        }
    }
}
