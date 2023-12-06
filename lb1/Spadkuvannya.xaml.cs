using lb1.lb2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using System.Windows.Shapes;

namespace lb1
{
    /// <summary>
    /// Interaction logic for Spadkuvannya.xaml
    /// </summary>
    public partial class Spadkuvannya : Window
    {
        public Spadkuvannya()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double Mark1 = Convert.ToDouble(mark1.Text), Mark2 = Convert.ToDouble(mark2.Text);
                if (Mark1 < 0 || Mark2 < 0 || Mark1 > 12 || Mark2 > 12)
                    throw new Exception("Помилково введені оцінки");

                double mVal;
                if (spach.Text == "Комп'ютерна Інженерія")
                    mVal = 800;
                else if (spach.Text == "Інженерія ПЗ")
                    mVal = 1100;
                else
                    mVal = 650;

                student s1 = new student(nam1.Text, Mark1);
                magistr m1 = new magistr(nam2.Text, Mark2, spach.Text, mVal);

                if (Mark1 < 6)
                    scol1.Content = "Занизький бал";
                else
                    scol1.Content = s1.scholarship();

                if (Mark2 < 6)
                    scol2.Content = "Занизький бал";
                else
                    scol2.Content = m1.scholarship();
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void nam2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
