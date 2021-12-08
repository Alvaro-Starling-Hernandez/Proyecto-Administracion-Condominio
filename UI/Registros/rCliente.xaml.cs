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

namespace ProyectoCondominio.UI.Registros
{
    /// <summary>
    /// Interaction logic for rCliente.xaml
    /// </summary>
    public partial class rCliente : Window
    {
        private Cliente cliente = new Cliente();
        public rCliente()
        {
            InitializeComponent();
            cliente = ClienteBLL.Buscar(1);
            this.DataContext = cliente;
        }

        private void ModificarButton_Click(object sender, RoutedEventArgs e)
        {
            NombreCompletoTextBox.IsEnabled = true;
            TipoDeDocumentoTextBox.IsEnabled = true;
            DocumentoTextBox.IsEnabled = true;
            CorreoTextBox.IsEnabled = true;
            TelefonoTextBox.IsEnabled = true;
            NombreCompletoTextBox.IsEnabled = true;
            GuardarButton.IsEnabled = true;
            ModificarButton.IsEnabled = false;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (NombreCompletoTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Nombre Completo está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                NombreCompletoTextBox.Focus();
            }

            if (TipoDeDocumentoTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Tipo Documento está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TipoDeDocumentoTextBox.Focus();
            }

            if (DocumentoTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Documento está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                DocumentoTextBox.Focus();
            }

            if (TelefonoTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo No. Telefono/Celular está vacio!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TelefonoTextBox.Focus();
            }

            if (CorreoTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Correo Electronico está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                CorreoTextBox.Focus();
            }

            return esValido;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = ClienteBLL.Guardar(cliente);

            if (paso)
            {
                MessageBox.Show("Transaccion exitosa!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                NombreCompletoTextBox.IsEnabled = false;
                TipoDeDocumentoTextBox.IsEnabled = false;
                DocumentoTextBox.IsEnabled = false;
                CorreoTextBox.IsEnabled = false;
                TelefonoTextBox.IsEnabled = false;
                NombreCompletoTextBox.IsEnabled = false;
                GuardarButton.IsEnabled = false;
                ModificarButton.IsEnabled = true;
            }
            else
                MessageBox.Show("Transaccion Fallida!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            
        }

        private void CambiarContraButton_Click(object sender, RoutedEventArgs e)
        {
            rCambiarContrasena rCambiar = new rCambiarContrasena();
            rCambiar.ShowDialog();
        }
    }
}
