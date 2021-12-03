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
    public class TipoAlquilerBLL
    {
        public static bool Guardar(TipoAlquiler tipoAlquiler)
        {
            if (!Existe(tipoAlquiler.IdTipoAlquiler))
            {
                return Insertar(tipoAlquiler);
            }
            else
            {
                return Modificar(tipoAlquiler);
            }
        }

        private static bool Insertar(TipoAlquiler tipoAlquiler)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.TipoAlquiler.Add(tipoAlquiler);
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

        public static bool Modificar(TipoAlquiler tipoAlquiler)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(tipoAlquiler).State = EntityState.Modified;
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
                var tipo = contexto.TipoAlquiler.Find(id);

                if (tipo != null)
                {
                    contexto.TipoAlquiler.Remove(tipo);
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

        public static TipoAlquiler Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TipoAlquiler tipo;

            try
            {
                tipo = contexto.TipoAlquiler.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tipo;
        }

        public static List<TipoAlquiler> GetList(Expression<Func<TipoAlquiler, bool>> criterio)
        {
            List<TipoAlquiler> lista = new List<TipoAlquiler>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoAlquiler.Where(criterio).ToList();
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
                encontrado = contexto.TipoAlquiler.Any(t => t.IdTipoAlquiler == id);
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

        public static bool ExisteNombre(string nombre)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.TipoAlquiler.Any(r => r.Descripcion == nombre);
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

        public static List<TipoAlquiler> GetTipoAlquiler()
        {
            List<TipoAlquiler> lista = new List<TipoAlquiler>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoAlquiler.ToList();
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
