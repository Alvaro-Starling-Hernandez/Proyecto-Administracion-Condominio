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
    public class DeudaBLL
    {
        public static bool Guardar(Deuda deuda)
        {
            if (!Existe(deuda.IdDeuda))
            {
                return Insertar(deuda);
            }
            else
            {
                return Modificar(deuda);
            }
        }

        private static bool Insertar(Deuda deuda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Deuda.Add(deuda);
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

        public static bool Modificar(Deuda deuda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(deuda).State = EntityState.Modified;
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
                var deuda = contexto.Deuda.Find(id);

                if (deuda != null)
                {
                    contexto.Deuda.Remove(deuda);
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

        public static Deuda Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Deuda deuda;

            try
            {
                deuda = contexto.Deuda.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return deuda;
        }

        public static Deuda BuscarPorPeriodo(Expression<Func<Deuda, bool>> criterio)
        {
            List<Deuda> lista = new List<Deuda>();
            Deuda deuda;
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Deuda.Where(criterio).ToList();
                deuda = lista.FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return deuda;
        }

        public static List<Deuda> GetList(Expression<Func<Deuda, bool>> criterio)
        {
            List<Deuda> lista = new List<Deuda>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Deuda.Where(criterio).ToList();
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
                encontrado = contexto.Deuda.Any(t => t.IdDeuda == id);
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


        public static List<Deuda> GetDeuda()
        {
            List<Deuda> lista = new List<Deuda>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Deuda.ToList();
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
