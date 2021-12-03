using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.Entidades
{
    public class Inmueble
    {
        [Key]
        public int IdInmueble { get; set; }
        public string Codigo { get; set; }
        public int IdTipoInmueble { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public float PrecioAlquiler { get; set; }

        [ForeignKey("IdTipoInmueble")]
        public virtual TipoInmueble TipoInmueble { get; set; }
    }
}
