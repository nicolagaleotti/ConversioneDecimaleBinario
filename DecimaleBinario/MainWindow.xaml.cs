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

        private void Button_Click(object sender, RoutedEventArgs ev)
        {
            string valore = txtValore.Text;
            string risultato = "";
            int mezzo = 0;
            try
            {
                if (scelta.SelectedIndex == 0)
                {
                    for (int c = 0; c < valore.Length; c++)
                    {
                        if (valore[c] != 1 & valore[c] != 0)
                            throw new Exception("Non si possono inserire valori diversi da 0 e 1");
                    }
                    // risultato = Convert.ToInt32(valore, 2 ).ToString();
                    int e = 0;
                    for (int i = valore.Length - 1; i >= 0; i--)
                    {

                        if (valore[i] == '1')
                            risultato = risultato + Math.Pow(2, e);
                        e++;
                    }
                }
                else
                {
                    // int numero = int.Parse(valore);
                    // risultato = Convert.ToString(numero, 2);
                    int numero = int.Parse(valore);
                    if (numero < 0)
                    {
                        throw new Exception("Non si possono inserire numeri minori di 0");
                    }
                    mezzo = numero;
                    do
                    {
                        if (mezzo % 2 == 0)
                        {
                            risultato = "0" + risultato;
                            mezzo = mezzo / 2;
                        }
                        else
                        {
                            risultato = "1" + risultato;
                            mezzo = (mezzo - 1) / 2;
                        }
                    } while (mezzo != 0);
                }
            txtRisultato.Content = $"Il risultato è {risultato}";
            }
            catch (Exception ex)
            {
                txtRisultato.Content = ex.Message;
            }
        }
    }
}
