using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ManagmentCinema.Models
{
    public partial class Db_CinemaContext : DbContext
    {
        public Db_CinemaContext()
        {
        }

        public Db_CinemaContext(DbContextOptions<Db_CinemaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<GenreFilm> GenreFilms { get; set; }
        public virtual DbSet<Projection> Projections { get; set; }
        public virtual DbSet<Promo> Promos { get; set; }
        public virtual DbSet<Salle> Salles { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cinema>(entity =>
            {
                entity.HasKey(e => e.IdC)
                    .HasName("PK__Cinema__DC501A2DA2226C7F");

                entity.ToTable("Cinema");

                entity.Property(e => e.IdC).HasColumnName("idC");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("adresse");

                entity.Property(e => e.Nom)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nom");

                entity.Property(e => e.Tel)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.IdF)
                    .HasName("PK__Film__DC501A2ADCB6045E");

                entity.ToTable("Film");

                entity.Property(e => e.IdF).HasColumnName("idF");

                entity.Property(e => e.DateSoortie)
                    .HasColumnType("date")
                    .HasColumnName("dateSoortie");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Duree).HasColumnName("duree");

                entity.Property(e => e.Langue)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("langue");

                entity.Property(e => e.Photo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Realisateur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("realisateur");

                entity.Property(e => e.Titre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titre");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.IdG)
                    .HasName("PK__Genre__DC501A29D9BA45D2");

                entity.ToTable("Genre");

                entity.Property(e => e.IdG).HasColumnName("idG");

                entity.Property(e => e.Capacite)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenreFilm>(entity =>
            {
                entity.HasKey(e => new { e.IdF, e.IdG })
                    .HasName("GenFil_PK");

                entity.ToTable("GenreFilm");

                entity.Property(e => e.IdF).HasColumnName("_idF");

                entity.Property(e => e.IdG).HasColumnName("_idG");

                entity.HasOne(d => d.IdFNavigation)
                    .WithMany(p => p.GenreFilms)
                    .HasForeignKey(d => d.IdF)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GenreFilm___idF__52593CB8");

                entity.HasOne(d => d.IdGNavigation)
                    .WithMany(p => p.GenreFilms)
                    .HasForeignKey(d => d.IdG)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GenreFilm___idG__534D60F1");
            });

            modelBuilder.Entity<Projection>(entity =>
            {
                entity.HasKey(e => e.IdP)
                    .HasName("PK__Projecti__DC501A205DA5F85F");

                entity.ToTable("Projection");

                entity.Property(e => e.IdP).HasColumnName("idP");

                entity.Property(e => e.DateProjection)
                    .HasColumnType("datetime")
                    .HasColumnName("dateProjection");

                entity.Property(e => e.IdF).HasColumnName("_idF");

                entity.Property(e => e.IdS).HasColumnName("_idS");

                entity.Property(e => e.TarifInitial).HasColumnName("tarifInitial");

                entity.HasOne(d => d.IdFNavigation)
                    .WithMany(p => p.Projections)
                    .HasForeignKey(d => d.IdF)
                    .HasConstraintName("FK__Projection___idF__5629CD9C");

                entity.HasOne(d => d.IdSNavigation)
                    .WithMany(p => p.Projections)
                    .HasForeignKey(d => d.IdS)
                    .HasConstraintName("FK__Projection___idS__571DF1D5");
            });

            modelBuilder.Entity<Promo>(entity =>
            {
                entity.HasKey(e => e.CodeP)
                    .HasName("PK__Promo__F4ABF97F94BD756C");

                entity.ToTable("Promo");

                entity.Property(e => e.CodeP)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DateDebutValidite)
                    .HasColumnType("date")
                    .HasColumnName("dateDebutValidite");

                entity.Property(e => e.DateFinValidite)
                    .HasColumnType("date")
                    .HasColumnName("dateFinValidite");

                entity.Property(e => e.IdF).HasColumnName("_idF");

                entity.Property(e => e.Jour)
                    .HasColumnType("date")
                    .HasColumnName("jour");

                entity.Property(e => e.Rabais).HasColumnName("rabais");

                entity.HasOne(d => d.IdFNavigation)
                    .WithMany(p => p.Promos)
                    .HasForeignKey(d => d.IdF)
                    .HasConstraintName("FK__Promo___idF__59FA5E80");
            });

            modelBuilder.Entity<Salle>(entity =>
            {
                entity.HasKey(e => e.IdS)
                    .HasName("PK__Salle__DC501A1D91029188");

                entity.ToTable("Salle");

                entity.Property(e => e.IdS).HasColumnName("idS");

                entity.Property(e => e.IdC).HasColumnName("_idC");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.Salles)
                    .HasForeignKey(d => d.IdC)
                    .HasConstraintName("FK__Salle___idC__4BAC3F29");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.IdT)
                    .HasName("PK__Tickets__DC501A1C55B93FFB");

                entity.Property(e => e.IdT).HasColumnName("idT");

                entity.Property(e => e.CodePromo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("_codePromo");

                entity.Property(e => e.DateVente)
                    .HasColumnType("date")
                    .HasColumnName("dateVente");

                entity.Property(e => e.IdP).HasColumnName("_idP");

                entity.HasOne(d => d.CodePromoNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.CodePromo)
                    .HasConstraintName("FK__Tickets___codePr__5CD6CB2B");

                entity.HasOne(d => d.IdPNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdP)
                    .HasConstraintName("FK__Tickets___idP__5DCAEF64");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
