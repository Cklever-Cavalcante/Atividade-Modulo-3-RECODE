using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AtividadeModulo.Models
{
    public partial class AgenciaViagensRecodeContext : DbContext
    {
        public AgenciaViagensRecodeContext(DbContextOptions<AgenciaViagensRecodeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Destino> Destinos { get; set; }
        public virtual DbSet<Pacote> Pacotes { get; set; }
        public virtual DbSet<Usa> Usas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(local);Database=AgenciaViagensRecode;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Clientes__677F38F5287B6F8B");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.CidadeReside)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cidade_reside");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.PaisReside)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais_reside");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("telefone")
                    .IsFixedLength(true);

                entity.Property(e => e.UfReside)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("uf_reside")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Compra__677F38F52413EECE");

                entity.ToTable("Compra");

                entity.Property(e => e.IdCliente)
                    .ValueGeneratedNever()
                    .HasColumnName("id_cliente");

                entity.Property(e => e.IdPacote).HasColumnName("id_pacote");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithOne(p => p.Compra)
                    .HasForeignKey<Compra>(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compra__id_clien__2C3393D0");

                entity.HasOne(d => d.IdPacoteNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.IdPacote)
                    .HasConstraintName("FK__Compra__id_pacot__2D27B809");
            });

            modelBuilder.Entity<Destino>(entity =>
            {
                entity.HasKey(e => e.IdDestino)
                    .HasName("PK__Destinos__F1DC09EAC961BF84");

                entity.Property(e => e.IdDestino).HasColumnName("id_destino");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cidade");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais");
            });

            modelBuilder.Entity<Pacote>(entity =>
            {
                entity.HasKey(e => e.IdPacote)
                    .HasName("PK__Pacotes__0B58B326D05B2DD3");

                entity.Property(e => e.IdPacote).HasColumnName("id_pacote");

                entity.Property(e => e.DataIda)
                    .HasColumnType("date")
                    .HasColumnName("data_ida");

                entity.Property(e => e.DataVolta)
                    .HasColumnType("date")
                    .HasColumnName("data_volta");

                entity.Property(e => e.HospedagemSimNao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("hospedagem_sim_nao")
                    .IsFixedLength(true);

                entity.Property(e => e.NumAcompanhantes).HasColumnName("num_acompanhantes");

                entity.Property(e => e.Preco).HasColumnName("preco");
            });

            modelBuilder.Entity<Usa>(entity =>
            {
                entity.HasKey(e => e.IdPacote)
                    .HasName("PK__Usa__0B58B326678537E1");

                entity.ToTable("Usa");

                entity.Property(e => e.IdPacote)
                    .ValueGeneratedNever()
                    .HasColumnName("id_pacote");

                entity.Property(e => e.IdDestino).HasColumnName("id_destino");

                entity.HasOne(d => d.IdDestinoNavigation)
                    .WithMany(p => p.Usas)
                    .HasForeignKey(d => d.IdDestino)
                    .HasConstraintName("FK__Usa__id_destino__2F10007B");

                entity.HasOne(d => d.IdPacoteNavigation)
                    .WithOne(p => p.Usa)
                    .HasForeignKey<Usa>(d => d.IdPacote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usa__id_pacote__2E1BDC42");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
