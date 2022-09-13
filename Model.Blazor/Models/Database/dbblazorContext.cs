using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Model.Blazor.Models.Database
{
    public partial class dbblazorContext : DbContext
    {
        public dbblazorContext()
        {
        }

        public dbblazorContext(DbContextOptions<dbblazorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DatosContacto> DatosContactos { get; set; }
        public virtual DbSet<DatosEducacion> DatosEducacions { get; set; }
        public virtual DbSet<DatosIdioma> DatosIdiomas { get; set; }
        public virtual DbSet<DatosLaboral> DatosLaborals { get; set; }
        public virtual DbSet<DatosPersonale> DatosPersonales { get; set; }
        public virtual DbSet<RegistroInicial> RegistroInicials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User= sa; Password= Ctek2314;Persist Security Info=False;Initial Catalog=dbblazor;Data Source=(local)\\A19");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AI");

            modelBuilder.Entity<DatosContacto>(entity =>
            {
                entity.HasKey(e => e.IdDatoContacto)
                    .HasName("PK__DatosCon__65515A727E28D348");

                entity.ToTable("DatosContacto");

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSecundario)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Facebook)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Instagram)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Linkedin)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinciaEstado)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Twiter)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosEducacion>(entity =>
            {
                entity.HasKey(e => e.IdDatoEducacion)
                    .HasName("PK__DatosEdu__80AF774C8B3E7EDC");

                entity.ToTable("DatosEducacion");

                entity.Property(e => e.AreaEstudio).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Institucion).IsUnicode(false);

                entity.Property(e => e.TituloCarrera).IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosIdioma>(entity =>
            {
                entity.HasKey(e => e.IdDatoIdioma)
                    .HasName("PK__DatosIdi__18DE4FE3FF920682");

                entity.ToTable("DatosIdioma");

                entity.Property(e => e.Estado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosLaboral>(entity =>
            {
                entity.HasKey(e => e.IdDatoLaboral)
                    .HasName("PK__DatosLab__BF6E6D558550766B");

                entity.ToTable("DatosLaboral");

                entity.Property(e => e.Empresa).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Puesto).IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosPersonale>(entity =>
            {
                entity.HasKey(e => e.IdDato)
                    .HasName("PK__DatosPer__F298CC9FA1E03F20");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimientoConsulta)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombresCompletos)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegistroInicial>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK__Registro__FFA45A99CA29E461");

                entity.ToTable("RegistroInicial");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
