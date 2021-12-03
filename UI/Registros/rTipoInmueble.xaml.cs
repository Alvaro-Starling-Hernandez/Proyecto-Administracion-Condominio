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
    /// Interaction logic for rTipoInmueble.xaml
    /// </summary>
    public partial class rTipoInmueble : Window
    {
        private TipoInmueble tipoInmueble = new TipoInmueble();

        public rTipoInmueble()
        {
            InitializeComponent();
            this.DataContext = tipoInmueble;
        }

        private void Limpiar()
        {
            this.tipoInmueble = new TipoInmueble();
            DescripcionTextBox.Text = "";
            this.DataContext = tipoInmueble;
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

            if (TipoInmuebleIdTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Tipo de Inmueble Id está vacio!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TipoInmuebleIdTextBox.Focus();
            }

            if (TipoInmuebleBLL.ExisteNombre(DescripcionTextBox.Text) == true)
            {
                esValido = false;

                MessageBox.Show("Ya existe un Tipo de Inmueble con esta descripción!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                DescripcionTextBox.Focus();
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var tipo = TipoInmuebleBLL.Buscar(Utilidades.ToInt(TipoInmuebleIdTextBox.Text));

            if (tipoInmueble != null)
                this.tipoInmueble = tipo;
            if (tipoInmueble == null)
            {
                MessageBox.Show("No existe un tipo de Inmueble con este Id!", "Fallo",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                this.tipoInmueble = new TipoInmueble();
            }

            this.DataContext = this.tipoInmueble;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = TipoInmuebleBLL.Guardar(tipoInmueble);

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
            if (TipoInmuebleBLL.Eliminar(Utilidades.ToInt(TipoInmuebleIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void TipoInmuebleIdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
