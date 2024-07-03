using aApprosModels.ModelsAppros;
using aApprosModels.ModelsBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCmdtApi.ApprosDbContext
{
    public class ApprosDbContext : DbContext
    {
        public ApprosDbContext(DbContextOptions<ApprosDbContext> options)
            : base(options)
        { }

        public virtual DbSet<Affectation> Affectations { get; set; }
        public virtual DbSet<AppelOffre> AppelOffres { get; set; }
        public virtual DbSet<Campagne> Campagnes { get; set; }
        public virtual DbSet<Cdtnt> Cdtnts { get; set; }
        public virtual DbSet<Contrat> Contrats { get; set; }
        public virtual DbSet<ContratDt> ContratDts { get; set; }
        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<Fournisseur> Fournisseurs { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Reception> Receptions { get; set; }
        public virtual DbSet<ReceptionDt> ReceptionDts { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<UniteAchat> UniteAchats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Campagne>().HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Affectation>(
              pr =>
              {
                  pr.Property(c => c.Libelle)
                  .HasMaxLength(256)
                  .IsRequired();
              });


            modelBuilder.Entity<AppelOffre>(
              pr =>
              {
                  pr.Property(b => b.NoAttribMarche)
                  .HasMaxLength(256)
                  .IsRequired();

                  pr.Property(c => c.NoAttribMarche)
                   .HasMaxLength(256)
                  .IsRequired();
              });

            modelBuilder.Entity<Campagne>(
              pr =>
              {
                  pr.Property(b => b.Libelle)
                  .HasMaxLength(256)
                  .IsRequired();

                  pr.Property(c => c.Abrege)
                   .HasMaxLength(256)
                  .IsRequired();
              });

            modelBuilder.Entity<Cdtnt>(
              pr =>
              {
                  pr.Property(b => b.Libelle)
                  .HasMaxLength(256)
                  .IsRequired();
              });

            modelBuilder.Entity<Contrat>(
              pr =>
              {
                  pr.Property(b => b.NoContrat)
                  .HasMaxLength(256)
                  .IsRequired();

                  pr.Property(c => c.DateContrat)
                  .IsRequired();
              });

            modelBuilder.Entity<ContratDt>(
              pr =>
              {
                  pr.Property(b => b.Qte)
                  .IsRequired();

                  pr.Property(c => c.PrixUnitaire)
                  .IsRequired();
              });

            modelBuilder.Entity<Direction>(
              pr =>
              {
                  pr.Property(b => b.Libelle)
                  .HasMaxLength(256)
                  .IsRequired();
              });


            modelBuilder.Entity<Fournisseur>(
              pr =>
              {
                  pr.Property(b => b.RaisonSociale)
                  .HasMaxLength(256)
                  .IsRequired();

                  pr.Property(c => c.Adresse)
                  .HasMaxLength(256)
                  .IsRequired();

                  pr.Property(d => d.Telephone1)
                  .HasMaxLength(256)
                  .IsRequired();

                  pr.Property(e => e.NIF)
                  .HasMaxLength(256)
                  .IsRequired();
              });

            modelBuilder.Entity<Produit>(
             pr =>
             {
                 pr.Property(b => b.Abrege)
                 .HasMaxLength(256)
                 .IsRequired();

                 pr.Property(c => c.Capacite)
                 .HasMaxLength(256)
                 .IsRequired();
             });

            modelBuilder.Entity<Reception>(
            pr =>
            {
                pr.Property(b => b.NoFactureFour)
                .HasMaxLength(256)
                .IsRequired();
            });
            modelBuilder.Entity<ReceptionDt>(
              pr =>
              {
                  pr.Property(b => b.QteRe)
                  .IsRequired();

                  pr.Property(c => c.PrixUnitaire)
                  .IsRequired();
              });

            modelBuilder.Entity<Status>(
             pr =>
             {
                 pr.Property(b => b.Libelle)
                 .HasMaxLength(256)
                 .IsRequired();
             });
            modelBuilder.Entity<UniteAchat>(
             pr =>
             {
                 pr.Property(b => b.Libelle)
                 .HasMaxLength(256)
                 .IsRequired();
             });
        }

    }
}
