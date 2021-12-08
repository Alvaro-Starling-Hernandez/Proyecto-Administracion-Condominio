using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.Entidades
{
    public class Mora
    {
        [Key]
        public int MoraId { get; set; }
        public float Porciento { get; set; }
    }
}
