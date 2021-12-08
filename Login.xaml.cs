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

namespace ProyectoCondominio
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Cliente cliente = new Cliente();
        public Login()
        {
            InitializeComponent();
            cliente = ClienteBLL.Buscar(1);
            NombreUsuarioTextBox.Focus();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private bool Validar()
        {
            bool esValido = true;

            if (NombreUsuarioTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Nombre de Usuario está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                NombreUsuarioTextBox.Focus();
            }

            if (ContrasenaPasswordBox.Password.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Contraseña está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                ContrasenaPasswordBox.Focus();
            }

            if (NombreUsuarioTextBox.Text != cliente.NombreUsuario || ContrasenaPasswordBox.Password != cliente.Clave)
            {
                esValido = false;

                MessageBox.Show("Nombre de usuario o contraseña incorrecto", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                NombreUsuarioTextBox.Focus();
                ContrasenaPasswordBox.Clear();
            }

            return esValido;
        }

        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {

            if (!Validar())
            {
                return;
            }
            else
            {
                MainWindow Principal = new MainWindow();
                this.Close();
                Principal.Show();
            }
                
        }

        private void ContrasenaPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                IngresarButton_Click(sender, e);
            }
        }

        private void NombreUsuarioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ContrasenaPasswordBox.Focus();
            }
        }
    }
}
