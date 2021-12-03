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
    }
}
