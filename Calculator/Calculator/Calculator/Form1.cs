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
    }
}
