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
    public class VistaBLL
    {
        public static bool Guardar(Vista vista)
        {
            if (!Existe(vista.VistaId))
            {
                return Insertar(vista);
            }
            else
            {
                return Modificar(vista);
            }
        }

        private static bool Insertar(Vista vista)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Vista.Add(vista);
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

        public static bool Modificar(Vista vista)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(vista).State = EntityState.Modified;
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
                var vista = contexto.Vista.Find(id);

                if (vista != null)
                {
                    contexto.Vista.Remove(vista);
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

        public static Vista Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Vista vista;

            try
            {
                vista = contexto.Vista.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return vista;
        }

        public static List<Vista> GetList(Expression<Func<Vista, bool>> criterio)
        {
            List<Vista> lista = new List<Vista>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Vista.Where(criterio).ToList();
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
                encontrado = contexto.Vista.Any(t => t.VistaId == id);
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

        public static List<Vista> GetVista()
        {
            List<Vista> lista = new List<Vista>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Vista.ToList();
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
