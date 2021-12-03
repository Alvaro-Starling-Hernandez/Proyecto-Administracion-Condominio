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
    public class TipoInmuebleBLL
    {
        public static bool Guardar(TipoInmueble tipoInmueble)
        {
            if (!Existe(tipoInmueble.IdTipoInmueble))
            {
                return Insertar(tipoInmueble);
            }
            else
            {
                return Modificar(tipoInmueble);
            }
        }

        private static bool Insertar(TipoInmueble tipoInmueble)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.TipoInmueble.Add(tipoInmueble);
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

        public static bool Modificar(TipoInmueble tipoInmueble)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(tipoInmueble).State = EntityState.Modified;
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
                var tipo = contexto.TipoInmueble.Find(id);

                if (tipo != null)
                {
                    contexto.TipoInmueble.Remove(tipo);
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

        public static TipoInmueble Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TipoInmueble tipo;

            try
            {
                tipo = contexto.TipoInmueble.Find(id);
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

        public static List<TipoInmueble> GetList(Expression<Func<TipoInmueble, bool>> criterio)
        {
            List<TipoInmueble> lista = new List<TipoInmueble>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoInmueble.Where(criterio).ToList();
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
                encontrado = contexto.TipoInmueble.Any(t => t.IdTipoInmueble == id);
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
                encontrado = contexto.TipoInmueble.Any(r => r.Descripcion == nombre);
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

        public static List<TipoInmueble> GetTipoInmueble()
        {
            List<TipoInmueble> lista = new List<TipoInmueble>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoInmueble.ToList();
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
