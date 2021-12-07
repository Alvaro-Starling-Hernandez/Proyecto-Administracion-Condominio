using ProyectoCondominio.BLL;
using ProyectoCondominio.DAL;
using ProyectoCondominio.Entidades;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for rPagoAlquiler.xaml
    /// </summary>
    public partial class rPagoAlquiler : Window
    {
        Alquiler alquiler = new Alquiler();

        public rPagoAlquiler()
        {
            InitializeComponent();
            this.DataContext = alquiler;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var tipo = AlquilerBLL.Buscar(Utilidades.ToInt(IdAlquilerTextBox.Text));

            
            if (alquiler != null)
            {
                this.alquiler = tipo;     
            }
                
            if (alquiler == null)
            {
                MessageBox.Show("No existe un Alquiler con este Id!", "Fallo",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                Limpiar();
                RegistrarPagoButton.IsEnabled = false;
            }

            if (tipo != null)
            {
                if (tipo.Estado == "CERRADO")
                {
                    MessageBox.Show("El Alquiler con este Id se encuentra CERRADO ya que ha realiizado todos los pagos!", "Fallo",
                       MessageBoxButton.OK, MessageBoxImage.Error);
                    Limpiar();
                    RegistrarPagoButton.IsEnabled = false;
                }
                if (tipo.Estado == "EN CURSO")
                {
                    RegistrarPagoButton.IsEnabled = true;
                    var Tipo = InmuebleBLL.Buscar(alquiler.IdInmueble);
                    var TipoInmueble = TipoInmuebleBLL.Buscar(Tipo.IdTipoInmueble);
                    CodigoInmuebleTextBox.Text = Tipo.Codigo;
                    TipoInmuebleDescripcionTextBox.Text = TipoInmueble.Descripcion;
                    DescripcionInmuebleTextBox.Text = Tipo.Descripcion;
                    PrecioAlquilerTextBox.Text = Tipo.PrecioAlquiler.ToString();

                    var TipoMoneda = TipoMonedaBLL.Buscar(alquiler.IdTipoMoneda);
                    TipoMonedTextBox.Text = TipoMoneda.Descripcion;

                    var TipoAlquiler = TipoAlquilerBLL.Buscar(alquiler.IdTipoAlquiler);
                    TipoAlquilerTextBox.Text = TipoAlquiler.Descripcion;

                    var ListaPeriodos = PeriodoBLL.GetList(x => x.IdAlquiler == alquiler.IdAlquiler);

                    foreach (var p in ListaPeriodos)
                    {
                        if (p.ProximoPagar == 1)
                        {
                            idPeriodoTextBox.Text = p.IdPeriodo.ToString();
                            PeriodoApagarTextBox.Text = p.NumeroPeriodo.ToString();
                            FechaLimitePeriodoTextBox.Text = p.FechaLimitePeriodo;
                        }

                    }

                    ImporteApagarTextBox.Focus();
                }
                
            }

            this.DataContext = this.alquiler;
        }

        private void Limpiar()
        {
            this.alquiler = new Alquiler();
            idPeriodoTextBox.Text = "";
            CodigoInmuebleTextBox.Text = "";
            TipoInmuebleDescripcionTextBox.Text = "";
            DescripcionInmuebleTextBox.Text = "";
            PrecioAlquilerTextBox.Text = "";
            PeriodoApagarTextBox.Text = "";
            FechaLimitePeriodoTextBox.Text = "";
            TipoAlquilerTextBox.Text = "";
            CantidadPeriodoTextBox.Text = "";
            TipoMonedTextBox.Text = "";
            ImporteApagarTextBox.Text = "";
            this.DataContext = alquiler;
        }

        private void RegistrarPagoButton_Click(object sender, RoutedEventArgs e)
        {
            bool _tienedeuda = false;
            decimal _montodeuda = 0;
            string mensaje = string.Empty;
            decimal _importepagar = 0;


            if (!decimal.TryParse(ImporteApagarTextBox.Text, out _importepagar))
            {
                MessageBox.Show("El formato de moneda no es correcto\nFormato ejemplo : 0.00", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            
            var alquiler = AlquilerBLL.Buscar(Utilidades.ToInt(IdAlquilerTextBox.Text));
            alquiler.CantidadPeriodo = int.Parse(CantidadPeriodoTextBox.Text);


            var periodo = PeriodoBLL.Buscar(Utilidades.ToInt(idPeriodoTextBox.Text));
            periodo.Monto = Convert.ToDecimal(ImporteApagarTextBox.Text);
            periodo.FechaPago = DateTime.Now.ToString("dd-MM-yyyy", new CultureInfo("en-US"));

            _montodeuda = decimal.Parse(PrecioAlquilerTextBox.Text) - _importepagar;

            _tienedeuda = _montodeuda > 0 ? true : false;
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            Contexto contexto = new Contexto();

            mensaje = string.Empty;
            bool paso = false, paso2 = false, paso3 = false, paso4 = false;
            bool respuesta = true;

            if (_tienedeuda)
            {
                Deuda deuda = new Deuda();
                deuda.IdPeriodo = periodo.IdPeriodo;
                deuda.MontoDeuda = _montodeuda.ToString("0.00");
                deuda.EstadoDeuda = "PENDIENTE";

                paso = DeudaBLL.Guardar(deuda);

                periodo.EstadoPeriodo = "EN DEUDA";
                periodo.ProximoPagar = 0;
                periodo.IdAlquiler = alquiler.IdAlquiler;

                paso2 = PeriodoBLL.Guardar(periodo);

            }
            else
            {
                periodo.EstadoPeriodo = "CANCELADO";
                periodo.ProximoPagar = 0;
                periodo.IdAlquiler = alquiler.IdAlquiler;

                paso2 = PeriodoBLL.Guardar(periodo);
            }

            //VALIDAMOS SI ES EL ULTIMO PERIODO A PAGAR
            if (alquiler.CantidadPeriodo > periodo.NumeroPeriodo)
            {
                var ListaPeriodos = PeriodoBLL.GetList(x => x.IdAlquiler == alquiler.IdAlquiler);

                foreach (var p in ListaPeriodos)
                {
                    if (p.NumeroPeriodo == periodo.NumeroPeriodo+1)
                    {
                        p.ProximoPagar = 1;
                        paso2 = PeriodoBLL.Guardar(p);
                    }

                }

            }
            else
            {
                alquiler.Estado = "CERRADO";
                paso3 = AlquilerBLL.Guardar(alquiler);
                var Tipo = InmuebleBLL.Buscar(alquiler.IdInmueble);
                Tipo.Estado = "LIBRE";
                paso4 = InmuebleBLL.Guardar(Tipo);

            }



            if (paso2 == false)
            {
                mensaje = "No se pudo registrar el pago";
                respuesta = false;
            }

            if (respuesta == false)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                

                if (_tienedeuda)
                {
                    MessageBox.Show("El pago fue registrado con una deuda pendiente", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El pago fue registrado existosamente!", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    Limpiar();
                }
                    
            }
        }

        private void ImporteApagarTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void IdAlquilerTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
