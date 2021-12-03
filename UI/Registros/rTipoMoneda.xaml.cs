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
    /// Interaction logic for rTipoMoneda.xaml
    /// </summary>
    public partial class rTipoMoneda : Window
    {
        private TipoMoneda tipoMoneda = new TipoMoneda();

        public rTipoMoneda()
        {
            InitializeComponent();
            this.DataContext = tipoMoneda;
        }

        private void Limpiar()
        {
            this.tipoMoneda = new TipoMoneda();
            DescripcionTextBox.Text = "";
            this.DataContext = tipoMoneda;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (DescripcionTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Descripcion está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                DescripcionTextBox.Focus();
            }

            if (TipoMonedaIdTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Tipo de moneda Id está vacio!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TipoMonedaIdTextBox.Focus();
            }

            if (TipoMonedaBLL.ExisteNombre(DescripcionTextBox.Text) == true)
            {
                esValido = false;

                MessageBox.Show("Ya existe un Tipo de moneda con esta descripción!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                DescripcionTextBox.Focus();
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var tipo = TipoMonedaBLL.Buscar(Utilidades.ToInt(TipoMonedaIdTextBox.Text));

            if (tipoMoneda != null)
                this.tipoMoneda = tipo;
            if (tipoMoneda == null)
            {
                MessageBox.Show("No existe un tipo de moneda con este Id!", "Fallo",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                this.tipoMoneda = new TipoMoneda();
            }
                
            this.DataContext = this.tipoMoneda;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = TipoMonedaBLL.Guardar(tipoMoneda);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion exitosa!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (TipoMonedaBLL.Eliminar(Utilidades.ToInt(TipoMonedaIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void TipoMonedaIdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
