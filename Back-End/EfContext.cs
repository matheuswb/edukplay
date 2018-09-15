using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api
{
    public partial class EfContext : DbContext
    {
        public EfContext()
        {
        }

        public EfContext(DbContextOptions<EfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Games> Games { get; set; }
        // public virtual DbSet<Login> Login { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=;Database=edukplay");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>(entity =>
            {
                entity.ToTable("games");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100);

                entity.Property(e => e.Imagem)
                    .HasColumnName("imagem")
                    .HasMaxLength(2000);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(60);

                entity.Property(e => e.Plataforma)
                    .HasColumnName("plataforma")
                    .HasMaxLength(60);
            });

            // modelBuilder.Entity<Login>(entity =>
            // {
            //     entity.ToTable("login");

            //     entity.Property(e => e.Id)
            //         .HasColumnName("id")
            //         .HasColumnType("int(11)");

            //     entity.Property(e => e.Senha)
            //         .HasColumnName("senha")
            //         .HasMaxLength(20);

            //     entity.Property(e => e.Usuario)
            //         .HasColumnName("usuario")
            //         .HasMaxLength(20);
            // });
        }
    }
}
