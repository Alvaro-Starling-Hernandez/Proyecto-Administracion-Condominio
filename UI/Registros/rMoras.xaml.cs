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
    /// Interaction logic for rMoras.xaml
    /// </summary>
    public partial class rMoras : Window
    {
        Mora mora = new Mora();
        public rMoras()
        {
            InitializeComponent();
            this.DataContext = mora;
            PorcientoTextBox.Focus();
            PorcientoTextBox.MaxLength = 4;
        }

        private void Limpiar()
        {
            this.mora = new Mora();
            PorcientoTextBox.Text = "";
            this.DataContext = mora;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (PorcientoTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Porcirnto está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                PorcientoTextBox.Focus();
            }


            if (PorcientoTextBox.Text.Contains("."))
            {
                string[] cadena = PorcientoTextBox.Text.Split(new char[] { '.' });

                if (cadena.Length != 2)
                {
                    esValido = false;
                    MessageBox.Show("Porciento no valido, no debe ingresar mas de un punto!", "Fallo",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                    PorcientoTextBox.Focus();
                }
                else
                {
                    if (MoraBLL.ExisteMora(Convert.ToSingle(PorcientoTextBox.Text)) == true)
                    {
                        esValido = false;

                        MessageBox.Show("Ya existe una Mora con este porciento!", "Fallo",
                            MessageBoxButton.OK, MessageBoxImage.Warning);
                        PorcientoTextBox.Focus();
                    }
                }


            }
            else
            {
                if (Convert.ToSingle(PorcientoTextBox.Text) <= 100)
                {
                    esValido = true;
                }
                else
                {
                    esValido = false;
                    MessageBox.Show("Porciento no puede ser mayor que 100!", "Fallo",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                    PorcientoTextBox.Focus();

                }
            }

            



            return esValido;
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var tipo = MoraBLL.Buscar(Utilidades.ToInt(IdMoraTextBox.Text));

            if (mora != null)
                this.mora = tipo;
            if (mora == null)
            {
                MessageBox.Show("No existe un tipo de Inmueble con este Id!", "Fallo",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                this.mora = new Mora();
            }

            this.DataContext = this.mora;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = MoraBLL.Guardar(mora);

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
            if (MoraBLL.Eliminar(Utilidades.ToInt(IdMoraTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void IdMoraTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PorcientoTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
