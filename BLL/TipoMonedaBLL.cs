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
    public class TipoMonedaBLL
    {
        public static bool Guardar(TipoMoneda tipoMoneda)
        {
            if (!Existe(tipoMoneda.IdTipoMoneda))
            {
                return Insertar(tipoMoneda);
            }
            else
            {
                return Modificar(tipoMoneda);
            }
        }

        private static bool Insertar(TipoMoneda tipoMoneda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.TipoMoneda.Add(tipoMoneda);
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

        public static bool Modificar(TipoMoneda tipoMoneda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(tipoMoneda).State = EntityState.Modified;
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
                var tipoMoneda = contexto.TipoMoneda.Find(id);

                if (tipoMoneda != null)
                {
                    contexto.TipoMoneda.Remove(tipoMoneda);
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

        public static TipoMoneda Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TipoMoneda tipo;

            try
            {
                tipo = contexto.TipoMoneda.Find(id);
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

        public static List<TipoMoneda> GetList(Expression<Func<TipoMoneda, bool>> criterio)
        {
            List<TipoMoneda> lista = new List<TipoMoneda>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoMoneda.Where(criterio).ToList();
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
                encontrado = contexto.TipoMoneda.Any(t => t.IdTipoMoneda == id);
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
                encontrado = contexto.TipoMoneda.Any(r => r.Descripcion == nombre);
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

        public static List<TipoMoneda> GetTipoMoneda()
        {
            List<TipoMoneda> lista = new List<TipoMoneda>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoMoneda.ToList();
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
