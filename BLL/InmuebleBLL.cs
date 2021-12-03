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
    public class InmuebleBLL
    {
        public static bool Guardar(Inmueble inmueble)
        {
            if (!Existe(inmueble.IdInmueble))
            {
                return Insertar(inmueble);
            }
            else
            {
                return Modificar(inmueble);
            }
        }

        private static bool Insertar(Inmueble inmueble)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                inmueble.Estado = "LIBRE";
                contexto.Inmueble.Add(inmueble);
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

        public static bool Modificar(Inmueble inmueble)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(inmueble).State = EntityState.Modified;
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
                var inmueble = contexto.Inmueble.Find(id);

                if (inmueble != null)
                {
                    contexto.Inmueble.Remove(inmueble);
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

        public static Inmueble Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inmueble inmueble;

            try
            {
                inmueble = contexto.Inmueble.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return inmueble;
        }

        public static List<Inmueble> GetList(Expression<Func<Inmueble, bool>> criterio)
        {
            List<Inmueble> lista = new List<Inmueble>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Inmueble.Where(criterio).ToList();
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
                encontrado = contexto.Inmueble.Any(t => t.IdInmueble == id);
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
                encontrado = contexto.Inmueble.Any(r => r.Codigo == codigo);
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

        public static List<Inmueble> GetInmueble()
        {
            List<Inmueble> lista = new List<Inmueble>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Inmueble.ToList();
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
