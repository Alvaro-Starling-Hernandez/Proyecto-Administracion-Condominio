using ProyectoCondominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.BLL
{
    public class Utilidades
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }

        public static Inmueble inmuebleAux;
        public static Alquiler alquiler;
        public static Deuda deudaAux;
        public static Cliente cliente;
        public static bool InmuebleSelect = false;
    }
}
