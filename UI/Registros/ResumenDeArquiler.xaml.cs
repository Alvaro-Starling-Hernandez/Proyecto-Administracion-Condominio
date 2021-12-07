using ProyectoCondominio.BLL;
using ProyectoCondominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoCondominio.UI.Registros
{
    /// <summary>
    /// Interaction logic for ResumenDeArquiler.xaml
    /// </summary>
    public partial class ResumenDeArquiler : Window
    {
        Alquiler alquiler = new Alquiler();
        public ResumenDeArquiler()
        {
            InitializeComponent();
            this.DataContext = alquiler;
        }

        private void IdAlquilerTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var tipo = AlquilerBLL.Buscar(Utilidades.ToInt(IdAlquilerTextBox.Text));


            if (alquiler != null)
            {
                this.alquiler = tipo;
            }

            if (alquiler == null)
            {
                MessageBox.Show("No existe un Alquiler con este Id!", "Fallo",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                Limpiar();
            }

            if (tipo != null)
            {
                if(tipo.Estado == "CERRADO")
                {
                    EstadoTextBlok.Foreground = Brushes.Blue;
                }

                if (tipo.Estado == "EN CURSO")
                {
                    EstadoTextBlok.Foreground = Brushes.LimeGreen;
                }

                if (tipo.Estado == "CANCELADO")
                {
                    EstadoTextBlok.Foreground = Brushes.Red;
                }

                var Tipo = InmuebleBLL.Buscar(alquiler.IdInmueble);
                var TipoInmueble = TipoInmuebleBLL.Buscar(Tipo.IdTipoInmueble);
                CodigoInmuebleTextBox.Text = Tipo.Codigo;
                TipoInmuebleDescripcionTextBox.Text = TipoInmueble.Descripcion;
                DescripcionInmuebleTextBox.Text = Tipo.Descripcion;

                var TipoMoneda = TipoMonedaBLL.Buscar(alquiler.IdTipoMoneda);
                TipoMonedTextBox.Text = TipoMoneda.Descripcion;

                var TipoAlquiler = TipoAlquilerBLL.Buscar(alquiler.IdTipoAlquiler);
                TipoAlquilerTextBox.Text = TipoAlquiler.Descripcion;

                List<Periodo> listado = new List<Periodo>();
                listado = PeriodoBLL.GetList(e => e.IdAlquiler == alquiler.IdAlquiler);
                DatosDataGrid.ItemsSource = null;
                DatosDataGrid.ItemsSource = listado;

            }

            this.DataContext = this.alquiler;
        }

        private void Limpiar()
        {
            this.alquiler = new Alquiler();
            CodigoInmuebleTextBox.Text = "";
            TipoInmuebleDescripcionTextBox.Text = "";
            DescripcionInmuebleTextBox.Text = "";
            TipoAlquilerTextBox.Text = "";
            CantidadPeriodoTextBox.Text = "";
            TipoMonedTextBox.Text = "";
            this.DataContext = alquiler;
        }
    }
}
