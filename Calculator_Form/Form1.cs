using System;
using System.Globalization;
using System.Windows.Forms;
using Methods;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Focus();
        }

        private double NoOne;
        private double NoTwo;
        private string Operator;
        private double Result;
        private bool flag;
        private bool opFlag;
        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"1";
            else
                textBox1.AppendText("1");
            opFlag = false;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"2";
            else
                textBox1.AppendText("2");
            opFlag = false;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"3";
            else
                textBox1.AppendText("3");
            opFlag = false;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"4";
            else
                textBox1.AppendText("4");
            opFlag = false;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"5";
            else
                textBox1.AppendText("5");
            opFlag = false;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"6";
            else
                textBox1.AppendText("6");
            opFlag = false;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"7";
            else
                textBox1.AppendText("7");
            opFlag = false;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"8";
            else
                textBox1.AppendText("8");
            opFlag = false;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"9";
            else
                textBox1.AppendText("9");
            opFlag = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            textBox1.Text = @"0";
            NoOne = 0;
            NoTwo = 0;
            opFlag = false;
            Operator = null;
            flag = false;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"=")
                buttonClear_Click(sender, e);
            if (opFlag)
                textBox1.Text = "";
            if (textBox1.Text == @"0")
                textBox1.Text = @"0";
            else
                textBox1.AppendText("0");
            opFlag = false;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            label1.Text = @"=";
            opFlag = true;
            try
            {
                NoTwo = double.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                buttonClear_Click(sender, e);
            }
            
            switch (Operator)
            {
                case "+":
                    Result = MyClass.Add(NoOne, NoTwo);
                    break;
                case "-":
                    Result = MyClass.Minus(NoOne, NoTwo);
                    break;
                case "*":
                    Result = MyClass.Multiply(NoOne, NoTwo);
                    break;
                case "/":
                    Result = MyClass.Divide(NoOne, NoTwo);
                    break;
                default:
                    Result = NoTwo;
                    break;

            }

            Operator = "=";
            textBox1.Text = Result.ToString(CultureInfo.InvariantCulture);
            NoOne = Result;
            NoTwo = 0;
            flag = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            buttonEqual_Click(sender, e);
            label1.Text = @"+";
            opFlag = true;
            Operator = "+";
            try
            {
                if (flag)
                    NoTwo = double.Parse(textBox1.Text);
                else
                    NoOne = double.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                buttonClear_Click(sender, e);
            }
        }


        private void buttonMinus_Click(object sender, EventArgs e)
        {
            buttonEqual_Click(sender, e);
            label1.Text = @"-";
            opFlag = true;
            Operator = "-";
            try
            {
                if (flag)
                    NoTwo = double.Parse(textBox1.Text);
                else
                    NoOne = double.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                buttonClear_Click(sender, e);
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            buttonEqual_Click(sender, e);
            label1.Text = @"*";
            opFlag = true;
            Operator = "*";
            try
            {
                if (flag)
                    NoTwo = double.Parse(textBox1.Text);
                else
                    NoOne = double.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                buttonClear_Click(sender, e);
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            buttonEqual_Click(sender, e);
            label1.Text = @"/";
            opFlag = true;
            Operator = "/";
            try
            {
                if (flag)
                    NoTwo = double.Parse(textBox1.Text);
                else
                    NoOne = double.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                buttonClear_Click(sender, e);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.TextLength > 1 ? textBox1.Text.Substring(0, textBox1.Text.Length - 1) : @"0";
        }
    }
}
