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
    public class PeriodoBLL
    {
        public static bool Guardar(Periodo periodo)
        {
            if (!Existe(periodo.IdPeriodo))
            {
                return Insertar(periodo);
            }
            else
            {
                return Modificar(periodo);
            }
        }

        private static bool Insertar(Periodo periodo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Periodo.Add(periodo);
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

        public static bool Modificar(Periodo periodo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(periodo).State = EntityState.Modified;
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
                var periodo = contexto.Periodo.Find(id);

                if (periodo != null)
                {
                    contexto.Periodo.Remove(periodo);
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

        public static Periodo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Periodo periodo;

            try
            {
                periodo = contexto.Periodo.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return periodo;
        }

        public static List<Periodo> GetList(Expression<Func<Periodo, bool>> criterio)
        {
            List<Periodo> lista = new List<Periodo>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Periodo.Where(criterio).ToList();
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
                encontrado = contexto.Periodo.Any(t => t.IdPeriodo == id);
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

        public static List<Periodo> GetPeriodo()
        {
            List<Periodo> lista = new List<Periodo>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Periodo.ToList();
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

        public static List<Periodo> Listar(int criterio)
        {
            List<Periodo> lista = new List<Periodo>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Periodo.Where(x => x.IdAlquiler == criterio).ToList();
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
    }
}
