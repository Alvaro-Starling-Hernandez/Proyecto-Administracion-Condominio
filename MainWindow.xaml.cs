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
            RtipoMoneda.Show();
        }

        private void TipoInmuebleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rTipoInmueble RtipoInmueble = new rTipoInmueble();
            RtipoInmueble.Show();
        }

        private void TipoAlquilerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rTipoAlquiler RtipoArquiler = new rTipoAlquiler();
            RtipoArquiler.Show();
        }

        private void InmuebleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rInmueble Rinmueble = new rInmueble();
            Rinmueble.Show();
        }

        private void AlquilerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rArquiler Ralquiler = new rArquiler();
            Ralquiler.Show();
        }

        private void cAlquilerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cAlquiler cAlquiler = new cAlquiler();
            cAlquiler.Show();
        }

        private void PagoAlquilerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rPagoAlquiler rPagoA = new rPagoAlquiler();
            rPagoA.Show();
        }

        private void cInmuebleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cInmuebleALL cinmuebleALL = new cInmuebleALL();
            cinmuebleALL.Show();
        }

        private void cHistorialDepagosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HistorialDePagos historialDePagos = new HistorialDePagos();
            historialDePagos.Show();
        }

        private void ResumenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ResumenDeArquiler resumenDeArquiler = new ResumenDeArquiler();
            resumenDeArquiler.Show();
        }
    }
}
