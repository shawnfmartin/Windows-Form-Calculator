using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_CalcUI
{
    public partial class CalculatorUI : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        bool operationPressed = false;

        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            string t = calculatorScreen.Text;
            string res = "";
            for(int i = 0; i < t.Length-1; i++)
            {
                res = res + t[i];
            }

            calculatorScreen.Text = res;


        
        }

        private void calculatorScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cButton_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "";
            firstNumber = 0;
            secondNumber = 0;
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(calculatorScreen.Text);

            switch (operation)
            {
                case "+":
                    calculatorScreen.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    calculatorScreen.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    calculatorScreen.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    calculatorScreen.Text = (firstNumber / secondNumber).ToString();
                    break;
                default:
                    break;
            }

            operationPressed = false;

        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0")
                calculatorScreen.Text = "";
            Button b = (Button)sender;
            calculatorScreen.Text = calculatorScreen.Text + b.Text;

        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(operationPressed == false)
                firstNumber = double.Parse(calculatorScreen.Text);

            calculatorScreen.Text = "";
            operationPressed = true;
            operation = b.Text;


        }

        private void boobButton_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "8008";
        }
    }
}
