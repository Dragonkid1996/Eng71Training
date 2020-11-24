using System;
using System.Collections.Generic;
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
using Calculator;

namespace Calculator_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        StringBuilder s = new StringBuilder();
        double num1, num2, temp;
        string operand;

        private void number_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content.ToString() == ".")
            {
                bool flag = false;
                foreach (var item in s.ToString())
                {
                    if (item == '.')
                    {
                        MessageBox.Show("Only 1 Decimal Point in a number!");
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    s.Append((sender as Button).Content.ToString());
                    CalcTextBlock.Text = s.ToString();
                }
            }
            else
            {
                s.Append((sender as Button).Content.ToString());
                CalcTextBlock.Text = s.ToString();
            }
        }

        public void equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num2 = Convert.ToDouble(s.ToString());
                s.Clear();
                switch (operand)
                {
                    case "+":
                        s.Append(CalculatorMethod.Add(num1, num2));
                        break;
                    case "-":
                        s.Append(CalculatorMethod.Subtract(num1, num2));
                        break;
                    case "*":
                        s.Append(CalculatorMethod.Multiply(num1, num2));
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            s.Clear();
                            s.Append("Error");
                        }
                        else
                        {
                            s.Append(Math.Round(CalculatorMethod.Divide(num1, num2),8));                            
                        }
                        break;
                    default:
                        break;
                }
                CalcTextBlock.Text = s.ToString();
                temp = Convert.ToDouble(s.ToString());
                s.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("You haven't entered any numbers!");
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                s.Clear();
                num1 = 0;
                num2 = 0;
                CalcTextBlock.Text = "0";
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Can't clear what isn't there!");
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                s.Remove(s.Length - 1, 1);
                if (s.Length == 0)
                {
                    CalcTextBlock.Text = "0";
                }
                else
                {
                    CalcTextBlock.Text = s.ToString();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Can't clear what isn't there!");
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            s.Append(temp);
            CalcTextBlock.Text = s.ToString();
        }

        private void off_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void operand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(s.ToString());
                s.Clear();
                operand = (sender as Button).Content.ToString();
                CalcTextBlock.Text = "0";
            }
            catch (FormatException)
            {
                MessageBox.Show("Tried to enter operand without a number!");
            }
        }
    }
}