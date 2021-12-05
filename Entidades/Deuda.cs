using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.Entidades
{
    public class Deuda
    {
        [Key]
        public int IdDeuda { get; set; }
        public int IdPeriodo { get; set; }
        public int NumeroPeriodo { get; set; }
        public string MontoDeuda { get; set; }
        public string EstadoDeuda { get; set; }
        public string FechaPago { get; set; }

        [ForeignKey("IdPeriodo")]
        public virtual Periodo Periodo { get; set; }
    }
}
