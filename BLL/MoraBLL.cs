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
    public class MoraBLL
    {
        public static bool Guardar(Mora mora)
        {
            if (!Existe(mora.MoraId))
            {
                return Insertar(mora);
            }
            else
            {
                return Modificar(mora);
            }
        }

        private static bool Insertar(Mora mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Mora.Add(mora);
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

        public static bool Modificar(Mora mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(mora).State = EntityState.Modified;
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
                var mora = contexto.Mora.Find(id);

                if (mora != null)
                {
                    contexto.Mora.Remove(mora);
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

        public static Mora Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Mora mora;

            try
            {
                mora = contexto.Mora.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return mora;
        }

        public static List<Mora> GetList(Expression<Func<Mora, bool>> criterio)
        {
            List<Mora> lista = new List<Mora>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Mora.Where(criterio).ToList();
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
                encontrado = contexto.Mora.Any(t => t.MoraId == id);
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

        public static bool ExisteMora(float mora)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Mora.Any(r => r.Porciento == mora);
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

        public static List<Mora> GetMora()
        {
            List<Mora> lista = new List<Mora>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Mora.ToList();
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
