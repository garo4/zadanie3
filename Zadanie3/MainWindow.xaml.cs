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

namespace Zadanie3
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = numberA.Text, b = numberB.Text;
            int A = Convert.ToInt32(a), B = Convert.ToInt32(b), d = b.Length - 1;
            char[] c = b.ToCharArray();

            for (; B > 0; d--)
            {
                if (c[c.Length - 1] == '3' || c[c.Length - 1] == '5' || c[c.Length - 1] == '7' || c[c.Length - 1] == '9')
                {

                    if (B == A)
                    { 
                        break;
                    }
                    if (B < A)
                    {
                        awnser.Text += ("Невозможно" + "\n");
                        break;
                    }

                }
                else if (c[c.Length - 1] == '1')
                {
                    B = (B - 1) / 10;
                    awnser.Text += (B + "   Добавляем 1" + "\n");


                    if (B == A)
                    {   
                        break;
                    }
                    if (B < A)
                    {
                        awnser.Text += ("Невозможно" + "\n");
                        break;
                    }
                }

                else if (c[c.Length - 1] == '2' || c[c.Length - 1] == '4' || c[c.Length - 1] == '6' || c[c.Length - 1] == '8' || c[c.Length - 1] == '0')
                {
                    B = B / 2;
                    awnser.Text += (B + "   Умножаем на 2" + "\n");

                    if (B == A)
                    {     
                        break;
                    }

                    if (B < A)
                    {
                        awnser.Text += ("Невозможно" + "\n");
                        break;
                    }
                }

                b = Convert.ToString(B);
                c = b.ToCharArray();
            }
        }
    }
}
