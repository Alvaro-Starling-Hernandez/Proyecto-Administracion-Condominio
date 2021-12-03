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
    /// Interaction logic for rInmueble.xaml
    /// </summary>
    public partial class rInmueble : Window
    {
        private Inmueble inmueble = new Inmueble();

        public rInmueble()
        {
            InitializeComponent();
            this.DataContext = inmueble;

            TipoInmuebleCombobox.ItemsSource = TipoInmuebleBLL.GetTipoInmueble();
            TipoInmuebleCombobox.SelectedValuePath = "IdTipoInmueble";
            TipoInmuebleCombobox.DisplayMemberPath = "Descripcion";
        }

        private void Limpiar()
        {
            this.inmueble = new Inmueble();
            DescripcionTextBox.Text = "";
            CodigoTextBox.Text = "";
            DirecionTextBox.Text = "";
            this.DataContext = inmueble;
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

            if (CodigoTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Codigo está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                CodigoTextBox.Focus();
            }

            if (DirecionTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Dirección está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                DirecionTextBox.Focus();
            }

            if (IdInmuebleTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Inmueble Id está vacio!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                IdInmuebleTextBox.Focus();
            }

            if (TipoInmuebleCombobox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Tipo Inmueble está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TipoInmuebleCombobox.Focus();
            }

            if (PrecioAlquilerTextBox.Text.Length == 0 || Convert.ToSingle(PrecioAlquilerTextBox.Text) <= 0)
            {
                esValido = false;

                if(Convert.ToSingle(PrecioAlquilerTextBox.Text) < 0)
                {
                    MessageBox.Show("El Precio Alquiler no puede ser menor que 0", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
                MessageBox.Show("El campo Precio Alquiler está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                PrecioAlquilerTextBox.Focus();
            }

            if (InmuebleBLL.ExisteCodigo(CodigoTextBox.Text) == true)
            {
                if(InmuebleBLL.Existe(Utilidades.ToInt(IdInmuebleTextBox.Text)) == true)
                {
                    return true;
                }
                esValido = false;

                MessageBox.Show("Ya existe un Inmueble con este Codigo!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                CodigoTextBox.Focus();
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var tipo = InmuebleBLL.Buscar(Utilidades.ToInt(IdInmuebleTextBox.Text));

            if (inmueble != null)
                this.inmueble = tipo;
            if (inmueble == null)
            {
                MessageBox.Show("No existe un Inmueble con este Id!", "Fallo",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                this.inmueble = new Inmueble();
            }

            this.DataContext = this.inmueble;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = InmuebleBLL.Guardar(inmueble);

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
            if (InmuebleBLL.Eliminar(Utilidades.ToInt(IdInmuebleTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void PrecioAlquilerTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void IdInmuebleTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
