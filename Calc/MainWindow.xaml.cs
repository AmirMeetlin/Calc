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
using System.Data;

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbActions.Text = "";
            tbCalculations.Text = "";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 7;
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 8;
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 9;
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 4;
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 5;
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 6;
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 1;
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 2;
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 3;
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = tbCalculations.Text + 0;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbCalculations.Text = "";
            tbActions.Text = "";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            

            if (tbCalculations.Text != "")
            {
                tbCalculations.Text = tbCalculations.Text + ":";
            }
            else
            {
                return;
            }

        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (tbCalculations.Text != "")
            {
                tbCalculations.Text = tbCalculations.Text + "x";
            }
            
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (tbCalculations.Text != "")
            {
                tbCalculations.Text = tbCalculations.Text + "-";
            }
            
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (tbCalculations.Text != "")
            {
                tbCalculations.Text = tbCalculations.Text + "+";
            }
            
        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            if (tbCalculations.Text != "")
            {
                tbCalculations.Text = tbCalculations.Text + ",";
            }
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            tbActions.Text = "";
            tbCalculations.Text = tbCalculations.Text.Remove(tbCalculations.Text.Length - 1);
        }

        private void btnPow_Click(object sender, RoutedEventArgs e)
        {
            if (tbCalculations.Text != "")
            {
                tbCalculations.Text = tbCalculations.Text + "^";
            }
            
        }

        private void btnEquate_Click(object sender, RoutedEventArgs e)
        {
            tbActions.Text = tbCalculations.Text;
            tbCalculations.Text = Calculations.Calculator(tbCalculations.Text).ToString();
            
        }

        int a = 0;
        private void tbCalculations_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if(a>0)
            {

            
            
                    btnComma.IsEnabled = true;
                    btnDivide.IsEnabled = true;
                    btnPow.IsEnabled = true;
                    btnMinus.IsEnabled = true;
                    btnMultiply.IsEnabled = true;
                    btnPlus.IsEnabled = true;

                if (tbCalculations.Text.Length!=0 && tbCalculations.Text[tbCalculations.Text.Length - 1] == ':')
                {
                    btnDivide.IsEnabled = false;
                    btnComma.IsEnabled = false;
                    btnPow.IsEnabled = false;
                    btnMinus.IsEnabled = false;
                    btnMultiply.IsEnabled = false;
                    btnPlus.IsEnabled = false;
                }
                if (tbCalculations.Text.Length != 0 && tbCalculations.Text[tbCalculations.Text.Length - 1] == '+')
                {
                    btnDivide.IsEnabled = false;
                    btnComma.IsEnabled = false;
                    btnPow.IsEnabled = false;
                    btnMinus.IsEnabled = false;
                    btnMultiply.IsEnabled = false;
                    btnPlus.IsEnabled = false;
                }
                if (tbCalculations.Text.Length != 0 && tbCalculations.Text[tbCalculations.Text.Length - 1] == '-')
                {
                    btnDivide.IsEnabled = false;
                    btnComma.IsEnabled = false;
                    btnPow.IsEnabled = false;
                    btnMinus.IsEnabled = false;
                    btnMultiply.IsEnabled = false;
                    btnPlus.IsEnabled = false;
                }
                if (tbCalculations.Text.Length != 0 && tbCalculations.Text[tbCalculations.Text.Length - 1] == 'x')
                {
                    btnDivide.IsEnabled = false;
                    btnComma.IsEnabled = false;
                    btnPow.IsEnabled = false;
                    btnMinus.IsEnabled = false;
                    btnMultiply.IsEnabled = false;
                    btnPlus.IsEnabled = false;
                }
                if (tbCalculations.Text.Length != 0 && tbCalculations.Text[tbCalculations.Text.Length - 1] == '^')
                {
                    btnDivide.IsEnabled = false;
                    btnComma.IsEnabled = false;
                    btnPow.IsEnabled = false;
                    btnMinus.IsEnabled = false;
                    btnMultiply.IsEnabled = false;
                    btnPlus.IsEnabled = false;
                }
                if (tbCalculations.Text.Length != 0 && tbCalculations.Text[tbCalculations.Text.Length - 1] == ',')
                {
                    btnDivide.IsEnabled = false;
                    btnComma.IsEnabled = false;
                    btnPow.IsEnabled = false;
                    btnMinus.IsEnabled = false;
                    btnMultiply.IsEnabled = false;
                    btnPlus.IsEnabled = false;
                }
            }
            a++;

        }
    }
}
