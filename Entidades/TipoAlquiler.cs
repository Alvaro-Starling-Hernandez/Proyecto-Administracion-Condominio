using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.Entidades
{
    public class TipoAlquiler
    {
        [Key]
        public int IdTipoAlquiler { get; set; }
        public string Descripcion { get; set; }
        public int Dias { get; set; }
        public int DefinidoSistema { get; set; }
        public int AplicaDias { get; set; }
    }
}
