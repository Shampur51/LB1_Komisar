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

namespace lb1
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

       // private void Button_Click(object sender, RoutedEventArgs e)
       // {
       // }

        private void Butt_Click(object sender, RoutedEventArgs e)
        {

            quadr q1, q2, q3;
            int ss1_1, ss1_2, ss1_3, ss1_4, agg1_1, agg1_2, agg1_3, agg1_4, agg2_1, agg2_2, agg2_3, agg2_4;

            try
            {
                ss1_1 = Convert.ToInt32(s1_1.Text);
                ss1_2 = Convert.ToInt32(s1_5.Text);
                ss1_3 = Convert.ToInt32(s1_3.Text);
                ss1_4 = Convert.ToInt32(s1_4.Text);
                ss1_1 = Convert.ToInt32(s1_1.Text);

                if (ss1_1 <= 0 || ss1_2 <= 0 || ss1_3 <= 0 || ss1_4 <= 0)
                    throw new Exception("Negativ value of segment");

                agg1_1 = Convert.ToInt32(ag1_1.Text);
                agg1_2 = Convert.ToInt32(ag1_2.Text);
                agg1_3 = Convert.ToInt32(ag1_3.Text);
                agg1_4 = Convert.ToInt32(ag1_4.Text);

                if (agg1_1 + agg1_2 + agg1_3 + agg1_4 != 360)
                    throw new Exception("The values ​​of the angles are not correct");
                else if ((agg1_1 == agg1_3 && agg1_2 == agg1_4) && (ss1_1 != ss1_3 || ss1_2 != ss1_4))
                    throw new Exception("Impossible values");
                else if ((ss1_1 == ss1_3 && ss1_2 == ss1_4) && (agg1_1 != agg1_3 || agg1_2 != agg1_4))
                    throw new Exception("Impossible values");

                agg2_1 = Convert.ToInt32(ag2_1.Text);
                agg2_2 = Convert.ToInt32(ag2_2.Text);
                agg2_3 = Convert.ToInt32(ag2_3.Text);
                agg2_4 = Convert.ToInt32(ag2_4.Text);

                if (agg2_1 + agg2_2 + agg2_3 + agg2_4 != 360)
                    throw new Exception("The values ​​of the angles are not correct");

                q1 = new quadr(ss1_1, ss1_2, ss1_3, ss1_4, agg1_1, agg1_2, agg1_3, agg1_4);
                q2 = new quadr(agg2_1, agg2_2, agg2_3, agg2_4);
                q3 = new quadr();

                s2_1.Content = q2.S1;
                s2_2.Content = q2.S2;
                s2_3.Content = q2.S3;
                s2_4.Content = q2.S4;


                s3_2.Content = q3.S1;
                s3_3.Content = q3.S2;
                s3_4.Content = q3.S3;
                s3_5.Content = q3.S4;

                ag3_1.Content = q3.Ag1;
                ag3_2.Content = q3.Ag2;
                ag3_3.Content = q3.Ag3;
                ag3_4.Content = q3.Ag4;

                if (q1.IsPar())
                    ch1.Content = "Так";
                else
                    ch1.Content = "Ні";

                if (q2.IsPar())
                    ch2.Content = "Так";
                else
                    ch2.Content = "Ні";

                if (q3.IsPar())
                    ch3.Content = "Так";
                else
                    ch3.Content = "Ні";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var l2wind = new Spadkuvannya();
            l2wind.Show();
        }
    }
}
