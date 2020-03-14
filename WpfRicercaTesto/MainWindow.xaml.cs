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

namespace WpfRicercaTesto
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cerca_Click(object sender, RoutedEventArgs e)
        {
            string ricerca = textBox1.Text;
            string da_cercare = textBox2.Text;
            bool esiste = ricerca.Contains(da_cercare);
            if (esiste == true)
            {
                lblRisultato.Content = (da_cercare);
            }
            else
                lblRisultato.Content = ("Non c'è il testo che stai cercando");
        }
    }
}
