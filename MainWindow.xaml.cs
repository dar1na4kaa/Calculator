using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String outputs = "";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button1(object sender, RoutedEventArgs e)
        {
            outputs += "1";
            outputBlock.Text = outputs;
        }

        private void Button2(object sender, RoutedEventArgs e)
        {
            outputs += "2";
            outputBlock.Text = outputs;
        }

        private void Button3(object sender, RoutedEventArgs e)
        {
            outputs += "3";
            outputBlock.Text = outputs;
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            outputs += "+";
            outputBlock.Text = outputs;
        }

        private void Button4(object sender, RoutedEventArgs e)
        {
            outputs += "4";
            outputBlock.Text = outputs;
        }

        private void Button5(object sender, RoutedEventArgs e)
        {
            outputs += "5";
            outputBlock.Text = outputs;
        }

        private void Button6(object sender, RoutedEventArgs e)
        {
            outputs += "6";
            outputBlock.Text = outputs;
        }

        private void MinusButton(object sender, RoutedEventArgs e)
        {
            outputs += "-";
            outputBlock.Text = outputs;
        }

        private void Button7(object sender, RoutedEventArgs e)
        {
            outputs += "7";
            outputBlock.Text = outputs;
        }

        private void Button8(object sender, RoutedEventArgs e)
        {
            outputs += "8";
            outputBlock.Text = outputs;
        }

        private void Button9(object sender, RoutedEventArgs e)
        {
            outputs += "9";
            outputBlock.Text = outputs;
        }

        private void MultButton(object sender, RoutedEventArgs e)
        {
            outputs += "*";
            outputBlock.Text = outputs;
        }

        private void CEbutton(object sender, RoutedEventArgs e)
        {
            char[] chars = outputs.ToCharArray();
            if (chars.Length == 1)
            {
                bool isCheck = true;
                int i = outputs.Length - 1;
                while (isCheck)
                {
                    switch (chars[i])
                    {
                        case '*':
                            outputs = "";
                            for (int j = 0; j <= i; j++)
                            {
                                outputs += chars[j];
                            }
                            isCheck = false;
                            break;

                        case '/':
                            outputs = "";
                            for (int j = 0; j <= i; j++)
                            {
                                outputs += chars[j];
                            }
                            isCheck = false;
                            break;

                        case '-':
                            outputs = "";
                            for (int j = 0; j <= i; j++)
                            {
                                outputs += chars[j];
                            }
                            isCheck = false;
                            break;

                        case '+':
                            outputs = "";
                            for (int j = 0; j <= i; j++)
                            {
                                outputs += chars[j];
                            }
                            isCheck = false;
                            break;
                        default:
                            isCheck = false;
                            outputs = "";
                            break;
                    }
                    i--;
                }
                outputBlock.Text = outputs;
            }
        }

        private void Cbutton(object sender, RoutedEventArgs e)
        {
            outputs = "";
            outputBlock.Text = outputs;
            resultBlock.Text = "";
        }

        private void LessButton(object sender, RoutedEventArgs e)
        {
            if (outputs.Length > 1)
            {
                outputs = outputs.Substring(0, outputs.Length - 1);
                outputBlock.Text = outputs;
            }
            else
            {
                outputs = "";
                outputBlock.Text = outputs;

            }

        }

        private void DivideButton(object sender, RoutedEventArgs e)
        {
            outputs += "/";
            outputBlock.Text = outputs;
        }

        private void ButtonPoint(object sender, RoutedEventArgs e)
        {
            outputs += ".";
            outputBlock.Text = outputs;
        }

        private void Button0(object sender, RoutedEventArgs e)
        {
            outputs += "0";
            outputBlock.Text = outputs;
        }

        private void CountButton(object sender, RoutedEventArgs e)
        {
            resultBlock.Text = "";
            char[] digits = outputs.ToCharArray();
            try
            {
                double result = double.Parse(digits[0].ToString());

                for (int i = 0; i < digits.Length; i++)
                {
                    switch (digits[i])
                    {
                        case '*':
                            result *= double.Parse(digits[i + 1].ToString());
                            break;

                        case '/':
                            result /= double.Parse(digits[i + 1].ToString());
                            break;

                        case '-':
                            result -= double.Parse(digits[i + 1].ToString());
                            break;

                        case '+':
                            result += double.Parse(digits[i + 1].ToString());
                            break;
                        default:
                            break;
                    }
                }
                resultBlock.Text = result + "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пропущено число");
            } catch (OverflowException) {
                MessageBox.Show("Число вышло за пределы");
            }
        }
    }
}
