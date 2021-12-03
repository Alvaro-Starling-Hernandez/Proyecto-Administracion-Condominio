using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.Entidades
{
    public class Periodo
    {
        [Key]
        public int IdPeriodo { get; set; }
        public int NumeroPeriodo { get; set; }
        public int IdAlquiler { get; set; }
        public DateTime FechaLimitePeriodo { get; set; }
        public string EstadoPeriodo { get; set; }
        public int ProximoPagar { get; set; }
        public decimal Monto { get; set; }
        public string FechaPago { get; set; }

        [ForeignKey("IdAlquiler")]
        public virtual Alquiler Alquiler { get; set; }
    }
}
