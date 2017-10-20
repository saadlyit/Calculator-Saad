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

namespace Calculator_Saad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long num1 = 0;
        long num2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 1;
                btntext.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                btntext.Text = num2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 2;
                btntext.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                btntext.Text = num2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 3;
                btntext.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                btntext.Text = num2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 4;
                btntext.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                btntext.Text = num2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 5;
                btntext.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                btntext.Text = num2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 6;
                btntext.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                btntext.Text = num2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 7;
                btntext.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                btntext.Text = num2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 8;
                btntext.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                btntext.Text = num2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 9;
                btntext.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                btntext.Text = num2.ToString();
            }
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            operation = "";
            btntext.Text = "0";
        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            btntext.Text = "0";
        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            btntext.Text = "0";
        }

        private void btnmultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            btntext.Text = "0";
        }

        private void btnequal_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    btntext.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    btntext.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    btntext.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    btntext.Text = (num1 / num2).ToString();
                    break;
            }
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            operation = "";
            num1 = 0;
            num2 = 0;
            btntext.Text = "0";
        }
    }
}
