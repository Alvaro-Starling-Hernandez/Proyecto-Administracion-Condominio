﻿using ProyectoCondominio.BLL;
using ProyectoCondominio.Entidades;
using ProyectoCondominio.UI.Registros;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for cInmueble.xaml
    /// </summary>
    public partial class cInmueble : Window
    {
        List<Inmueble> listado = new List<Inmueble>();
        public cInmueble()
        {
            InitializeComponent();
            listado = InmuebleBLL.GetList(x => true && x.Estado == "LIBRE");
            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
            var conteo = listado.Count;
            ConteoTextbox.Text = conteo.ToString();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DatosDataGrid.SelectedItem != null)
            {
                Utilidades.inmuebleAux = (Inmueble)DatosDataGrid.SelectedItem;
                Utilidades.InmuebleSelect = true;
                Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Inmueble", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Inmueble> listado = new List<Inmueble>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                switch (Filtro_ComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            listado = InmuebleBLL.GetList(e => e.IdInmueble == Utilidades.ToInt(Criterio_TextBox.Text) && e.Estado == "LIBRE");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 1:
                        try
                        {
                            listado = InmuebleBLL.GetList(d => d.Codigo.ToLower().Contains(Criterio_TextBox.Text.ToLower()) && d.Estado == "LIBRE");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 2:
                        try
                        {
                            listado = InmuebleBLL.GetList(d => d.Direccion.ToLower().Contains(Criterio_TextBox.Text.ToLower()) && d.Estado == "LIBRE");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 3:
                        try
                        {
                            listado = InmuebleBLL.GetList(d => d.Descripcion.ToLower().Contains(Criterio_TextBox.Text.ToLower()) && d.Estado == "LIBRE");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 4:
                        try
                        {
                            listado = InmuebleBLL.GetList(d => d.Estado.ToLower().Contains(Criterio_TextBox.Text.ToLower()) && d.Estado == "LIBRE");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 5:
                        try
                        {
                            listado = InmuebleBLL.GetList(d => d.PrecioAlquiler == Convert.ToSingle(Criterio_TextBox.Text) && d.Estado == "LIBRE");
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
                listado = InmuebleBLL.GetList(x => true && x.Estado == "LIBRE");
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

            var conteo = listado.Count;
            ConteoTextbox.Text = conteo.ToString();
        }
    }
}
