using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.Entidades
{
    public class TipoInmueble
    {
        [Key]
        public int IdTipoInmueble { get; set; }
        public string Descripcion { get; set; }
    }
}
