using ProyectoCondominio.BLL;
using ProyectoCondominio.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace ProyectoCondominio.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cPagoDeDeuda.xaml
    /// </summary>
    public partial class cPagoDeDeuda : Window
    {
        public cPagoDeDeuda()
        {
            InitializeComponent();
        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Deuda> listado = new List<Deuda>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                try
                {
                    var alquiler = AlquilerBLL.Buscar(Utilidades.ToInt(Criterio_TextBox.Text));
                    var listadoPeriodo = PeriodoBLL.GetList(x => x.IdAlquiler == Utilidades.ToInt(Criterio_TextBox.Text));

                    foreach (var p in listadoPeriodo)
                    {
                        if(p.EstadoPeriodo == "EN DEUDA")
                        {
                            var deuda = DeudaBLL.BuscarPorPeriodo(x => x.IdPeriodo == p.IdPeriodo);
                            listado.Add(deuda);
                        }
                    }
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
            if (conteo == 0)
            {
                MessageBox.Show("No existe Alquiler con este Id!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Criterio_TextBox.Focus();
            }
        }

        private void PagarButton_Click(object sender, RoutedEventArgs e)
        {
            Utilidades.deudaAux = (Deuda)DatosDataGrid.SelectedItem;
            var deuda = DeudaBLL.Buscar(Utilidades.deudaAux.IdDeuda);
            if (Utilidades.deudaAux.EstadoDeuda == "PENDIENTE")
            {

                if (MessageBox.Show("¿Desea cancelar la deuda?", "Mensaje", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    deuda.EstadoDeuda = "CANCELADO";
                    deuda.FechaPago = DateTime.Now.ToString("dd-MM-yyyy", new CultureInfo("en-US"));
                    var paso = DeudaBLL.Guardar(deuda);

                    var periodo = PeriodoBLL.Buscar(deuda.IdPeriodo);
                    periodo.EstadoPeriodo = "CANCELADO";
                    var paso2 = PeriodoBLL.Guardar(periodo);
                    Buscar_Button_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Esta Deuda se encuentra paga!", "Avertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
