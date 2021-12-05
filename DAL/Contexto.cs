using Microsoft.EntityFrameworkCore;
using ProyectoCondominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCondominio.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Alquiler> Alquiler { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Deuda> Deuda { get; set; }
        public DbSet<Inmueble> Inmueble { get; set; }
        public DbSet<Periodo> Periodo { get; set; }
        public DbSet<TipoAlquiler> TipoAlquiler { get; set; }
        public DbSet<TipoInmueble> TipoInmueble { get; set; }
        public DbSet<TipoMoneda> TipoMoneda { get; set; }
        public DbSet<Vista> Vista { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\DBDATOS.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                IdCliente = 1,
                Nombre = "admin",
                TipoDocumento = "Cedula",
                Documento = "1234",
                Telefono = "809-999-9999",
                Correo = "cliente@gmail.com",
                Clave = "1234"
            });
        }
    }
}
