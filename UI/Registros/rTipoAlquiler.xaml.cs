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
    /// Interaction logic for rTipoAlquiler.xaml
    /// </summary>
    public partial class rTipoAlquiler : Window
    {
        private TipoAlquiler tipoAlquiler = new TipoAlquiler();

        public rTipoAlquiler()
        {
            InitializeComponent();
            this.DataContext = tipoAlquiler;
        }

        private void Limpiar()
        {
            this.tipoAlquiler = new TipoAlquiler();
            DescripcionTextBox.Text = "";
            this.DataContext = tipoAlquiler;
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

            if (DiasTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Cantidad de Dias está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                DiasTextBox.Focus();
            }

            if (TipoAlquilerIdTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Tipo de Alquiler Id está vacio!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TipoAlquilerIdTextBox.Focus();
            }

            if (TipoAlquilerBLL.ExisteNombre(DescripcionTextBox.Text) == true)
            {
                if(TipoAlquilerBLL.Existe(Utilidades.ToInt(TipoAlquilerIdTextBox.Text)) == true){
                    return true;
                }
                esValido = false;

                MessageBox.Show("Ya existe un Tipo de Alquiler con esta descripción!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                DescripcionTextBox.Focus();
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var tipo = TipoAlquilerBLL.Buscar(Utilidades.ToInt(TipoAlquilerIdTextBox.Text));

            if (tipoAlquiler != null)
                this.tipoAlquiler = tipo;
            if (tipoAlquiler == null)
            {
                MessageBox.Show("No existe un tipo de Alquiler con este Id!", "Fallo",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                this.tipoAlquiler = new TipoAlquiler();
            }

            this.DataContext = this.tipoAlquiler;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = TipoAlquilerBLL.Guardar(tipoAlquiler);

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
            if (TipoAlquilerBLL.Eliminar(Utilidades.ToInt(TipoAlquilerIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void TipoAlquilerIdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void DiasTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
