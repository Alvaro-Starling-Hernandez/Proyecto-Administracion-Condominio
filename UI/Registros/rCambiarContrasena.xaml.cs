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
    /// Interaction logic for rCambiarContrasena.xaml
    /// </summary>
    public partial class rCambiarContrasena : Window
    {
        private Cliente cliente = new Cliente();
        public rCambiarContrasena()
        {
            InitializeComponent();
            cliente = ClienteBLL.Buscar(1);
        }

        private bool Validar()
        {
            bool esValido = true;

            if (ContrasenaPasswordBox.Password.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo contraseña Actual está vacia", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                ContrasenaPasswordBox.Focus();
            }

            if (NuevaPasswordBox.Password.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Nueva Contraseña está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                NuevaPasswordBox.Focus();
            }

            if (ConfirmarPasswordBox.Password.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Confirmar Contraseña está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                ConfirmarPasswordBox.Focus();
            }

            if(ContrasenaPasswordBox.Password != cliente.Clave)
            {
                esValido = false;

                MessageBox.Show("Contraseña Incorrecta", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                ContrasenaPasswordBox.Focus();
            }

            if (NuevaPasswordBox.Password != ConfirmarPasswordBox.Password)
            {
                esValido = false;

                MessageBox.Show("Contraseñas no coinciden", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                ConfirmarPasswordBox.Focus();
            }

            return esValido;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;
            cliente.Clave = NuevaPasswordBox.Password;
            var paso = ClienteBLL.Guardar(cliente);

            if (paso)
            {
                MessageBox.Show("Contraseña Cambiada!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
                MessageBox.Show("Transaccion Fallida!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
