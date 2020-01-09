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

namespace WPFTemperatura
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
        int i = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int quantità = int.Parse(TxtQuantità.Text);
            double[] temperatura = new double[quantità];
            double valorenumerico = double.Parse(TxtNumero.Text);

            for (int i = 0; i < temperatura.Length; i++)
            {
                temperatura[i] = valorenumerico;
            }
            LblRisultato.Content = Esercizio4.Temperatura.MediaTemperature(temperatura);
        }
    }
}

