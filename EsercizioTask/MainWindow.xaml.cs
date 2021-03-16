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

namespace EsercizioTask
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

        private void Multipli(object sender, RoutedEventArgs e)
        {
            int n;
            try
            {
                n = Convert.ToInt32(txtNumero);
                Program p = new Program(n);
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "inserisci un numero...", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
           
        }
    }
}
