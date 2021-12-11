using ProyectoCondominio.BLL;
using ProyectoCondominio.Entidades;
using ProyectoCondominio.UI.Recibos;
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
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace ProyectoCondominio.UI.Consultas
{
    /// <summary>
    /// Interaction logic for HistorialDePagos.xaml
    /// </summary>
    public partial class HistorialDePagos : Window
    {
        public HistorialDePagos()
        {
            InitializeComponent();
        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Periodo> listado = new List<Periodo>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                try
                {
                    listado = PeriodoBLL.GetList(e => e.IdAlquiler == Utilidades.ToInt(Criterio_TextBox.Text));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un Id de alquiler.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                Criterio_TextBox.Focus();
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

            var conteo = listado.Count;
            ConteoTextbox.Text = conteo.ToString();
            if(conteo == 0)
            {
                MessageBox.Show("No existe Alquiler con este Id!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Criterio_TextBox.Focus();
            }
        }

        private void DescargarButtom_Click(object sender, RoutedEventArgs e)
        {
            FacturaPagoAlquiler facturaPago = new FacturaPagoAlquiler();

            var periodo = (Periodo)DatosDataGrid.SelectedItem;

            facturaPago.FechaPagoLabel.Content = periodo.FechaPago;
            facturaPago.NumeroPeriodo.Content = periodo.NumeroPeriodo;
            facturaPago.ImportePagado.Content = periodo.Monto;

            var propietario = ClienteBLL.Buscar(1);
            facturaPago.NombreCompletoLabel.Content = propietario.Nombre;
            facturaPago.TipoDocuemntoLabel.Content = propietario.TipoDocumento;
            facturaPago.DocuemntoLabel.Content = propietario.Documento;



            var alquilerSelecionado = AlquilerBLL.Buscar(periodo.IdAlquiler);

            facturaPago.CodigoLabel.Content = alquilerSelecionado.CodigoAlquiler;
            facturaPago.NombreCompletoInquilinoLabel.Content = alquilerSelecionado.NombreCliente;
            facturaPago.TipoDocuemntoInquilinoLabel.Content = alquilerSelecionado.TipoDocumentoCliente;
            facturaPago.DocuemntoInquilinoLabel.Content = alquilerSelecionado.DocumentoCliente;

            var inmueble = InmuebleBLL.Buscar(alquilerSelecionado.IdInmueble);

            facturaPago.CodigoImuebleLabel.Content = inmueble.Codigo;
            facturaPago.DescripcionLabel.Content = inmueble.Descripcion;

            var tipoInmueble = TipoInmuebleBLL.Buscar(inmueble.IdTipoInmueble);
            facturaPago.TipoInmuebleLael.Content = tipoInmueble.Descripcion;


            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(facturaPago.print, "Factura Pago Alquiler");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
