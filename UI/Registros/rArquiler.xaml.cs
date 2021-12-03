using ProyectoCondominio.BLL;
using ProyectoCondominio.Entidades;
using ProyectoCondominio.UI.Consultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
    /// Interaction logic for rArquiler.xaml
    /// </summary>
    public partial class rArquiler : Window
    {
        private Alquiler alquiler = new Alquiler();
        public rArquiler()
        {
            InitializeComponent();
            this.DataContext = alquiler;

            TipoAlquilerCombobox.ItemsSource = TipoAlquilerBLL.GetTipoAlquiler();
            TipoAlquilerCombobox.SelectedValuePath = "IdTipoAlquiler";
            TipoAlquilerCombobox.DisplayMemberPath = "Descripcion";

            TipoMonedaCombobox.ItemsSource = TipoMonedaBLL.GetTipoMoneda();
            TipoMonedaCombobox.SelectedValuePath = "IdTipoMoneda";
            TipoMonedaCombobox.DisplayMemberPath = "Descripcion";
        }

        private void Limpiar()
        {
            this.alquiler = new Alquiler();
            CodigoTextBox.Text = "";//
            NombreClienteTextBox.Text = "";//
            TipoDocumentoClienteTextBox.Text = "";//
            DocumentoClienteTextBox.Text = "";//
            TelefonoClienteTextBox.Text = "";//
            CorreoClienteTextBox.Text = "";//
            NacionalidadClienteTextBox.Text = "";//
            CodigoInmuebleTextBox.Text = "";//
            TipoInmuebleDescripcionTextBox.Text = "";//
            DescripcionInmuebleTextBox.Text = "";//
            CantidadPeriodoTextBox.Text = "";
            PrecioAlquilerTextBox.Text = "";
            this.DataContext = alquiler;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (NombreClienteTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Nombre de Cliente está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                NombreClienteTextBox.Focus();
            }

            if (CodigoTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Codigo está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                CodigoTextBox.Focus();
            }

            if (TipoDocumentoClienteTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Tipo Docuemento está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TipoDocumentoClienteTextBox.Focus();
            }

            if (DocumentoClienteTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Número Documento está vacio!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                DocumentoClienteTextBox.Focus();
            }

            if (TelefonoClienteTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Número Telefono/Celular está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TelefonoClienteTextBox.Focus();
            }

            if (CorreoClienteTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Correo Electronico está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                CorreoClienteTextBox.Focus();
            }

            if (NacionalidadClienteTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Nacionalidad está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                NacionalidadClienteTextBox.Focus();
            }

           /* if (CodigoInmuebleTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Codigo Inmueble está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }*/

            if (CantidadPeriodoTextBox.Text.Length == 0)
            {
                esValido = false;

                MessageBox.Show("El campo Cantidad de periodos está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TelefonoClienteTextBox.Focus();
            }
            /* if (PrecioAlquilerTextBox.Text.Length == 0 || Convert.ToSingle(PrecioAlquilerTextBox.Text) <= 0)
             {
                 esValido = false;

                 if (Convert.ToSingle(PrecioAlquilerTextBox.Text) < 0)
                 {
                     MessageBox.Show("El Precio Alquiler no puede ser menor que 0", "Fallo",
                     MessageBoxButton.OK, MessageBoxImage.Warning);
                     return false;
                 }
                 MessageBox.Show("El campo Precio Alquiler está vacio", "Fallo",
                     MessageBoxButton.OK, MessageBoxImage.Warning);
                 PrecioAlquilerTextBox.Focus();
             }*/

            /*if (InmuebleBLL.ExisteCodigo(CodigoTextBox.Text) == true)
            {
                if (InmuebleBLL.Existe(Utilidades.ToInt(IdInmuebleTextBox.Text)) == true)
                {
                    return true;
                }
                esValido = false;

                MessageBox.Show("Ya existe un Inmueble con este Codigo!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                CodigoTextBox.Focus();
            }*/

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var tipo = AlquilerBLL.Buscar(Utilidades.ToInt(IdAlquilerTextBox.Text));

            if (alquiler != null)
                this.alquiler = tipo;
            if (alquiler == null)
            {
                MessageBox.Show("No existe un Alquiler con este Id!", "Fallo",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                this.alquiler = new Alquiler();
                CodigoInmuebleTextBox.Text = "";//
                TipoInmuebleDescripcionTextBox.Text = "";//
                DescripcionInmuebleTextBox.Text = "";//
                PrecioAlquilerTextBox.Text = "";
            }

            if (tipo != null)
            {
                var Tipo = InmuebleBLL.Buscar(alquiler.IdInmueble);
                var TipoInmueble = TipoInmuebleBLL.Buscar(Tipo.IdTipoInmueble);
                CodigoInmuebleTextBox.Text = Tipo.Codigo;
                TipoInmuebleDescripcionTextBox.Text = TipoInmueble.Descripcion;
                DescripcionInmuebleTextBox.Text = Tipo. Descripcion;
                PrecioAlquilerTextBox.Text = Tipo.PrecioAlquiler.ToString();
            }

            this.DataContext = this.alquiler;
      
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            alquiler.FechaInicioAlquiler = Convert.ToDateTime(FechaInicioAlquilerDatePicker.Text);
            alquiler.CantidadPeriodo = Convert.ToInt32(CantidadPeriodoTextBox.Text);


            DateTime fechafinperiodo = alquiler.FechaInicioAlquiler;
            List<Periodo> listaPeriodos = new List<Periodo>();
            var tipoAlquiler = TipoAlquilerBLL.Buscar(alquiler.IdTipoAlquiler);
            
            int dias = alquiler.CantidadPeriodo * tipoAlquiler.Dias;
            fechafinperiodo = fechafinperiodo.AddDays(dias);
            for (int i = 1; i <= alquiler.CantidadPeriodo; i++)
            {
                listaPeriodos.Add(new Periodo()
                {
                    NumeroPeriodo = i,
                    FechaLimitePeriodo = fechafinperiodo,
                    EstadoPeriodo = "PENDIENTE",
                    ProximoPagar = i == 1 ? 1 : 0
                });
            }
            
            alquiler.FechaFinAlquiler = fechafinperiodo;
            var paso = AlquilerBLL.Guardar(alquiler);

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
            if (AlquilerBLL.Eliminar(Utilidades.ToInt(IdAlquilerTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void IdAlquilerTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void CantidadPeriodoTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BuscarIInmueble_Click(object sender, RoutedEventArgs e)
        {
            cInmueble Cinmueble = new cInmueble();
            Cinmueble.ShowDialog();
            
            if(Utilidades.InmuebleSelect == true)
            {
                var Tipo = TipoInmuebleBLL.Buscar(Utilidades.inmuebleAux.IdTipoInmueble);
                alquiler.IdInmueble = Utilidades.inmuebleAux.IdInmueble;
                CodigoInmuebleTextBox.Text = Utilidades.inmuebleAux.Codigo;
                TipoInmuebleDescripcionTextBox.Text = Tipo.Descripcion;
                DescripcionInmuebleTextBox.Text = Utilidades.inmuebleAux.Descripcion;
                PrecioAlquilerTextBox.Text = Utilidades.inmuebleAux.PrecioAlquiler.ToString();
            }
            
        }
    }
}
