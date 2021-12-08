using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.Entidades
{
    public class Alquiler
    {
        [Key]
        public int IdAlquiler { get; set; }
        public string CodigoAlquiler { get; set; }
        public string NombreCliente { get; set; }
        public string TipoDocumentoCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string CorreoCliente { get; set; }
        public string NacionalidadCliente { get; set; }
        public int IdInmueble { get; set; }
        public int IdTipoAlquiler { get; set; }
        public int IdTipoMoneda { get; set; }
        public int CantidadPeriodo { get; set; }
        public int MoraId { get; set; }
        public DateTime FechaInicioAlquiler { get; set; } = DateTime.Now;
        public DateTime FechaFinAlquiler { get; set; } = DateTime.Now;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public string Estado { get; set; }

        [ForeignKey("IdInmueble")]
        public virtual Inmueble Inmueble { get; set; }

        [ForeignKey("IdTipoAlquiler")]
        public virtual TipoAlquiler TipoAlquiler { get; set; }

        [ForeignKey("IdTipoMoneda")]
        public virtual TipoMoneda TipoMoneda { get; set; }

        [ForeignKey("MoraId")]
        public virtual Mora Mora { get; set; }
    }
}
