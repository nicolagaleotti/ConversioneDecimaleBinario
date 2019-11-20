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

namespace DecimaleBinario
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string valore = txtValore.Text;
            string risultato;
            if (scelta.SelectedIndex == 0)
            {
                risultato = Convert.ToInt32(valore, 2 ).ToString();
            }
            else
            {
                int n = int.Parse(valore);
                risultato = Convert.ToString(n, 2);
            }
            txtRisultato.Content = risultato;
        }
    }
}
