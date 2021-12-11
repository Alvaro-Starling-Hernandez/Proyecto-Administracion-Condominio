using ProyectoCondominio.BLL;
using ProyectoCondominio.Entidades;
using ProyectoCondominio.UI.Recibos;
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
    /// Interaction logic for cAlquiler.xaml
    /// </summary>
    public partial class cAlquiler : Window
    {
        public cAlquiler()
        {
            InitializeComponent();
        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Alquiler> listado = new List<Alquiler>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                switch (Filtro_ComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = AlquilerBLL.GetList(
                                    c => c.FechaRegistro.Date >= Desde_DataPicker.SelectedDate &&
                                    c.FechaRegistro.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.IdAlquiler == Utilidades.ToInt(Criterio_TextBox.Text)
                                );
                            else
                                listado = AlquilerBLL.GetList(e => e.IdAlquiler == Utilidades.ToInt(Criterio_TextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 1:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = AlquilerBLL.GetList(
                                    c => c.FechaRegistro.Date >= Desde_DataPicker.SelectedDate &&
                                    c.FechaRegistro.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.CodigoAlquiler.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = AlquilerBLL.GetList(d => d.CodigoAlquiler.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 2:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = AlquilerBLL.GetList(
                                    c => c.FechaRegistro.Date >= Desde_DataPicker.SelectedDate &&
                                    c.FechaRegistro.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.NombreCliente.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = AlquilerBLL.GetList(d => d.NombreCliente.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 3:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = AlquilerBLL.GetList(
                                    c => c.FechaRegistro.Date >= Desde_DataPicker.SelectedDate &&
                                    c.FechaRegistro.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.DocumentoCliente.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = AlquilerBLL.GetList(d => d.DocumentoCliente.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 4:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = AlquilerBLL.GetList(
                                    c => c.FechaRegistro.Date >= Desde_DataPicker.SelectedDate &&
                                    c.FechaRegistro.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Estado.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = AlquilerBLL.GetList(d => d.Estado.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;


                }
            }
            else
            {
                if (Desde_DataPicker.SelectedDate != null)
                    listado = AlquilerBLL.GetList(e => e.FechaRegistro.Date >= Desde_DataPicker.SelectedDate);

                if (Desde_DataPicker.SelectedDate != null)
                    listado = AlquilerBLL.GetList(e => e.FechaRegistro.Date <= Hasta_DatePicker.SelectedDate);

                if (Desde_DataPicker.SelectedDate == null && Hasta_DatePicker.SelectedDate == null)
                    listado = AlquilerBLL.GetList(x => true);
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

            var conteo = listado.Count;
            ConteoTextbox.Text = conteo.ToString();
        }

        private void DescargarButtom_Click(object sender, RoutedEventArgs e)
        {
            ContratoDeAlquiler contrato = new ContratoDeAlquiler();

            var alquiler = (Alquiler)DatosDataGrid.SelectedItem;

            contrato.FechaRegistroLabel.Content = alquiler.FechaRegistro.ToShortDateString();
            contrato.CodigoLabel.Content = alquiler.CodigoAlquiler;
            contrato.NombreCompletoInquilinoLabel.Content = alquiler.NombreCliente;
            contrato.TipoDocuemntoInquilinoLabel.Content = alquiler.TipoDocumentoCliente;
            contrato.DocuemntoInquilinoLabel.Content = alquiler.DocumentoCliente;
            contrato.CorreoInquilinoLabel.Content = alquiler.CorreoCliente;
            contrato.TelefonoInquilinoLabel.Content = alquiler.TelefonoCliente;
            contrato.FechaInicioLabel.Content = alquiler.FechaInicioAlquiler.ToShortDateString();
            contrato.CantidadPeriodoslabel.Content = alquiler.CantidadPeriodo;

            var propietario = ClienteBLL.Buscar(1);
            contrato.NombreCompletoLabel.Content = propietario.Nombre;
            contrato.TipoDocuemntoLabel.Content = propietario.TipoDocumento;
            contrato.DocuemntoLabel.Content = propietario.Documento;
            contrato.CorreoLabel.Content = propietario.Correo;
            contrato.TelefonoLabel.Content = propietario.Telefono;

            var inmueble = InmuebleBLL.Buscar(alquiler.IdInmueble);

            contrato.CodigoImuebleLabel.Content = inmueble.Codigo;
            contrato.DescripcionLabel.Content = inmueble.Descripcion;
            contrato.PrecioLabel.Content = inmueble.PrecioAlquiler;


            var tipoInmueble = TipoInmuebleBLL.Buscar(inmueble.IdTipoInmueble);
            contrato.TipoInmuebleLael.Content = tipoInmueble.Descripcion;

            var tipoAlquiler = TipoAlquilerBLL.Buscar(alquiler.IdTipoAlquiler);
            contrato.TipoAlquilerLabel.Content = tipoAlquiler.Descripcion;

            var tipoMoneda = TipoMonedaBLL.Buscar(alquiler.IdTipoMoneda);
            contrato.TipoMonedaLabel.Content = tipoMoneda.Descripcion;


            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(contrato.print2, "Detalle De Contrato");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
