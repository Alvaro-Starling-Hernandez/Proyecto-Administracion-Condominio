﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoCondominio.DAL;

namespace ProyectoCondominio.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211201174114_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("ProyectoCondominio.Entidades.Alquiler", b =>
                {
                    b.Property<int>("IdAlquiler")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadPeriodo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodigoAlquiler")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorreoCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentoCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaFinAlquiler")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicioAlquiler")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdInmueble")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTipoAlquiler")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTipoMoneda")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NacionalidadCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonoCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDocumentoCliente")
                        .HasColumnType("TEXT");

                    b.HasKey("IdAlquiler");

                    b.HasIndex("IdInmueble");

                    b.HasIndex("IdTipoAlquiler");

                    b.HasIndex("IdTipoMoneda");

                    b.ToTable("Alquiler");
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Documento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("TEXT");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            IdCliente = 1,
                            Clave = "1234",
                            Correo = "cliente@gmail.com",
                            Documento = "1234",
                            Nombre = "admin",
                            Telefono = "809-999-9999",
                            TipoDocumento = "Cedula"
                        });
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.Inmueble", b =>
                {
                    b.Property<int>("IdInmueble")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdTipoInmueble")
                        .HasColumnType("INTEGER");

                    b.Property<float>("PrecioAlquiler")
                        .HasColumnType("REAL");

                    b.HasKey("IdInmueble");

                    b.HasIndex("IdTipoInmueble");

                    b.ToTable("Inmueble");
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.Periodo", b =>
                {
                    b.Property<int>("IdPeriodo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EstadoPeriodo")
                        .HasColumnType("TEXT");

                    b.Property<string>("FechaLimitePeriodo")
                        .HasColumnType("TEXT");

                    b.Property<string>("FechaPago")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdAlquiler")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroPeriodo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProximoPagar")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdPeriodo");

                    b.HasIndex("IdAlquiler");

                    b.ToTable("Periodo");
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.TipoAlquiler", b =>
                {
                    b.Property<int>("IdTipoAlquiler")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AplicaDias")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DefinidoSistema")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Dias")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdTipoAlquiler");

                    b.ToTable("TipoAlquiler");
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.TipoInmueble", b =>
                {
                    b.Property<int>("IdTipoInmueble")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("IdTipoInmueble");

                    b.ToTable("TipoInmueble");
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.TipoMoneda", b =>
                {
                    b.Property<int>("IdTipoMoneda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("IdTipoMoneda");

                    b.ToTable("TipoMoneda");
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.Vista", b =>
                {
                    b.Property<int>("VistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodigoContrato")
                        .HasColumnType("TEXT");

                    b.Property<string>("FechaLimite")
                        .HasColumnType("TEXT");

                    b.Property<string>("MontoDeuda")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroPeriodo")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoAlquiler")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoInmueble")
                        .HasColumnType("TEXT");

                    b.HasKey("VistaId");

                    b.ToTable("Vista");
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.Alquiler", b =>
                {
                    b.HasOne("ProyectoCondominio.Entidades.Inmueble", "Inmueble")
                        .WithMany()
                        .HasForeignKey("IdInmueble")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoCondominio.Entidades.TipoAlquiler", "TipoAlquiler")
                        .WithMany()
                        .HasForeignKey("IdTipoAlquiler")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoCondominio.Entidades.TipoMoneda", "TipoMoneda")
                        .WithMany()
                        .HasForeignKey("IdTipoMoneda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inmueble");

                    b.Navigation("TipoAlquiler");

                    b.Navigation("TipoMoneda");
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.Inmueble", b =>
                {
                    b.HasOne("ProyectoCondominio.Entidades.TipoInmueble", "TipoInmueble")
                        .WithMany()
                        .HasForeignKey("IdTipoInmueble")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoInmueble");
                });

            modelBuilder.Entity("ProyectoCondominio.Entidades.Periodo", b =>
                {
                    b.HasOne("ProyectoCondominio.Entidades.Alquiler", "Alquiler")
                        .WithMany()
                        .HasForeignKey("IdAlquiler")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alquiler");
                });
#pragma warning restore 612, 618
        }
    }
}
