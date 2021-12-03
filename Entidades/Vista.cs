using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.Entidades
{
    public class Vista
    {
        [Key]
        public int VistaId { get; set; }
        public string CodigoContrato { get; set; }
        public string NombreCliente { get; set; }
        public string TipoAlquiler { get; set; }
        public string TipoInmueble { get; set; }
        public string NumeroPeriodo { get; set; }
        public string FechaLimite { get; set; }
        public string MontoDeuda { get; set; }
    }
}
