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

namespace WpfApp2
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double summaelect = (double.Parse(Electnew.Text) - double.Parse(Electold.Text)) *
                double.Parse(Electtariff.Text);

            double summacoldwater = (double.Parse(Coldwaternew.Text)
                                     - double.Parse(Coldwaterold.Text)) * double.Parse(Colfwatertariff.Text);

            double suumahotwater = (double.Parse(Hotwaternew.Text) - double.Parse(Hotwaterold.Text)) *
                                    double.Parse(Hotwatertariff.Text);

            double summa = summaelect + summacoldwater + suumahotwater;
            Summaresult.Text = summa.ToString("F2");
        }
    }
}
