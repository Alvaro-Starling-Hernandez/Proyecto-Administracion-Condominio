using ProyectoCondominio.BLL;
using ProyectoCondominio.Entidades;
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
    }
}
