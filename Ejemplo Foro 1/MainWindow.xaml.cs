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

namespace Ejemplo_Foro_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string mensaje;
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void but1_Click(object sender, RoutedEventArgs e)
        {
            mensaje = "Hola Mundo" + " saludos al Foro 1";
            Label2.Content = mensaje;

            
        }

        private void label1_Initialized(object sender, EventArgs e)
        {
            mensaje = "Programa Funcionando";
            label1.Content = mensaje;
        }

        
    }
}
