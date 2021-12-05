using Microsoft.EntityFrameworkCore;
using ProyectoCondominio.DAL;
using ProyectoCondominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.BLL
{
    public class AlquilerBLL
    {
        public static bool Guardar(Alquiler alquiler)
        {
            if (!Existe(alquiler.IdAlquiler))
            {
                return Insertar(alquiler);
            }
            else
            {
                return Modificar(alquiler);
            }
        }

        private static bool Insertar(Alquiler alquiler)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                alquiler.Estado = "EN CURSO";
                contexto.Alquiler.Add(alquiler);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Alquiler alquiler)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(alquiler).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var alquiler = contexto.Alquiler.Find(id);

                if (alquiler != null)
                {
                    contexto.Alquiler.Remove(alquiler);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Alquiler Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Alquiler alquiler;

            try
            {
                alquiler = contexto.Alquiler.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return alquiler;
        }

        public static List<Alquiler> GetList(Expression<Func<Alquiler, bool>> criterio)
        {
            List<Alquiler> lista = new List<Alquiler>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Alquiler.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Alquiler.Any(t => t.IdAlquiler == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static bool ExisteCodigo(string codigo)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Alquiler.Any(r => r.CodigoAlquiler == codigo);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static List<Alquiler> GetAlquiler()
        {
            List<Alquiler> lista = new List<Alquiler>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Alquiler.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        /*public static bool Pagar(Alquiler oAlquiler, Periodo oPeriodo, bool TieneDeuda, decimal MontoDeuda, out string mensaje)
        {
            Contexto contexto = new Contexto();

            mensaje = string.Empty;
            bool paso = false,paso2 = false, paso3 = false, paso4 = false;
            bool respuesta = true;

            if (TieneDeuda)
            {
                Deuda deuda = new Deuda();
                deuda.IdPeriodo = oPeriodo.IdPeriodo;
                deuda.MontoDeuda = MontoDeuda.ToString("0.00");
                deuda.EstadoDeuda = "PENDIENTE";

                paso = DeudaBLL.Guardar(deuda);

                oPeriodo.EstadoPeriodo = "EN DEUDA";
                oPeriodo.ProximoPagar = 0;
                oPeriodo.IdAlquiler = oAlquiler.IdAlquiler;

                paso2 = PeriodoBLL.Guardar(oPeriodo);

                *//*query.AppendLine(string.Format("update PERIODO set EstadoPeriodo = 'EN DEUDA' , ProximoPagar = 0 ," +
                " Monto = '{0}', FechaPago='{1}' WHERE IdAlquiler = {2} AND IdPeriodo = {3} AND NumeroPeriodo = {4};" +
                "", oPeriodo.Monto, oPeriodo.FechaPago, oAlquiler.IdAlquiler, oPeriodo.IdPeriodo, oPeriodo.NumeroPeriodo));*//*
            }
            else
            {
                oPeriodo.EstadoPeriodo = "CANCELADO";
                oPeriodo.ProximoPagar = 0;
                oPeriodo.IdAlquiler = oAlquiler.IdAlquiler;

                paso2 = PeriodoBLL.Guardar(oPeriodo);
                *//*              query.AppendLine(string.Format("update PERIODO set EstadoPeriodo = 'CANCELADO' , ProximoPagar = 0 , Monto = '{0}', FechaPago='{1}' WHERE IdAlquiler = {2} AND IdPeriodo = {3} AND NumeroPeriodo = {4};", oPeriodo.Monto, oPeriodo.FechaPago, oAlquiler.IdAlquiler, oPeriodo.IdPeriodo, oPeriodo.NumeroPeriodo));
                *//*
            }

            //VALIDAMOS SI ES EL ULTIMO PERIODO A PAGAR
            if (oAlquiler.CantidadPeriodo > oPeriodo.NumeroPeriodo)
            {
                oPeriodo.NumeroPeriodo += 1;

                paso2 = PeriodoBLL.Guardar(oPeriodo);
                *//*query.AppendLine(string.Format("UPDATE PERIODO SET ProximoPagar = 1 WHERE IdAlquiler = {0} AND NumeroPeriodo = {1};", oAlquiler.IdAlquiler, oPeriodo.NumeroPeriodo));*//*
            }
            else
            {
                oAlquiler.Estado = "CERRADO";
                paso3 = AlquilerBLL.Guardar(oAlquiler);
                var Tipo = InmuebleBLL.Buscar(oAlquiler.IdInmueble);
                Tipo.Estado = "LIBRE";
                paso4 = InmuebleBLL.Guardar(Tipo);

                *//*query.AppendLine(string.Format("UPDATE ALQUILER SET Estado = 'CERRADO' where IdAlquiler = {0};", oAlquiler.IdAlquiler));
                query.AppendLine(string.Format("UPDATE INMUEBLE SET Estado = 'LIBRE' WHERE IdInmueble = (SELECT IdInmueble FROM ALQUILER WHERE IdAlquiler ={0});", oAlquiler.IdAlquiler));*//*
            }


                

            if (paso == false && paso2 == false && paso3 == false && paso4 == false)
            {
                mensaje = "No se pudo registrar el pago";
                respuesta = false;

            }

            return respuesta;
        }*/
    }
}
