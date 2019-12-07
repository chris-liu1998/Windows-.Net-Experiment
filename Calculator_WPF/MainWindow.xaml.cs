using Methods;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private double NoOne;
        private double NoTwo;
        private string Operator;
        private double Result;
        private bool flag;
        private bool opFlag;

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"1";
            else
                textBox.AppendText("1");
            opFlag = false;
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"2";
            else
                textBox.AppendText("2");
            opFlag = false;
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"3";
            else
                textBox.AppendText("3");
            opFlag = false;
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"4";
            else
                textBox.AppendText("4");
            opFlag = false;
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"5";
            else
                textBox.AppendText("5");
            opFlag = false;
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"6";
            else
                textBox.AppendText("6");
            opFlag = false;
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"7";
            else
                textBox.AppendText("7");
            opFlag = false;
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"8";
            else
                textBox.AppendText("8");
            opFlag = false;
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"9";
            else
                textBox.AppendText("9");
            opFlag = false;
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if ((string)label.Content == "=")
                btnClear_Click(sender, e);
            if (opFlag)
                textBox.Text = "";
            if (textBox.Text == @"0")
                textBox.Text = @"0";
            else
                textBox.AppendText("0");
            opFlag = false;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            label.Content = "";
            textBox.Text = @"0";
            NoOne = 0;
            NoTwo = 0;
            Operator = null;
            flag = false;
            opFlag = false;
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText(".");
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text.Length > 1 ? textBox.Text.Substring(0, textBox.Text.Length - 1) : @"0";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            btnEqual_Click(sender, e);
            label.Content = @"+";
            opFlag = true;
            Operator = "+";
            try
            {
                if (flag)
                    NoTwo = double.Parse(textBox.Text);
                else
                    NoOne = double.Parse(textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                btnClear_Click(sender, e);
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            btnEqual_Click(sender, e);
            label.Content = @"-";
            opFlag = true;
            Operator = "-";
            try
            {
                if (flag)
                    NoTwo = double.Parse(textBox.Text);
                else
                    NoOne = double.Parse(textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                btnClear_Click(sender, e);
            }
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            btnEqual_Click(sender, e);
            label.Content = @"×";
            opFlag = true;
            Operator = "*";
            try
            {
                if (flag)
                    NoTwo = double.Parse(textBox.Text);
                else
                    NoOne = double.Parse(textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                btnClear_Click(sender, e);
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            btnEqual_Click(sender, e);
            label.Content = @"÷";
            opFlag = true;
            Operator = "/";
            try
            {
                if (flag)
                    NoTwo = double.Parse(textBox.Text);
                else
                    NoOne = double.Parse(textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                btnClear_Click(sender, e);
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            label.Content = @"=";
            opFlag = true;
            textBox.Focus();
            try
            {
                NoTwo = double.Parse(textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"不允许使用多个‘.’");
                btnClear_Click(sender, e);
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
            textBox.Text = Result.ToString(CultureInfo.InvariantCulture);
            NoOne = Result;
            NoTwo = 0;
            flag = true;
        }
    }
}
