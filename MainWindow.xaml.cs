using ProyectoCondominio.UI.Consultas;
using ProyectoCondominio.UI.Registros;
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

namespace ProyectoCondominio
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

        private void TipoMonedaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rTipoMoneda RtipoMoneda = new rTipoMoneda();
            RtipoMoneda.ShowDialog();
        }

        private void TipoInmuebleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rTipoInmueble RtipoInmueble = new rTipoInmueble();
            RtipoInmueble.ShowDialog();
        }

        private void TipoAlquilerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rTipoAlquiler RtipoArquiler = new rTipoAlquiler();
            RtipoArquiler.ShowDialog();
        }

        private void InmuebleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rInmueble Rinmueble = new rInmueble();
            Rinmueble.ShowDialog();
        }

        private void AlquilerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rArquiler Ralquiler = new rArquiler();
            Ralquiler.ShowDialog();
        }

        private void cAlquilerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cAlquiler cAlquiler = new cAlquiler();
            cAlquiler.ShowDialog();
        }
    }
}
