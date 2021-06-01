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
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            if(cbSimbol.SelectedIndex==-1||tbNum1.Text=="" || tbNum2.Text == "")
            {
                MessageBox.Show("Введите все данные!");
            }
            else
            { 
            double a = Convert.ToDouble(tbNum1.Text);
            double b = Convert.ToDouble(tbNum2.Text);
                tbResult.Text =Convert.ToString(Calculations.Calculator(a, b, cbSimbol.SelectedIndex));



            }
        }
    }
}
