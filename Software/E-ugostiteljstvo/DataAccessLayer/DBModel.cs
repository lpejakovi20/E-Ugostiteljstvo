using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using EntitiesLayer.Entities;

namespace DataAccessLayer
{
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<iskoristenost_namirnice> iskoristenost_namirnice { get; set; }
        public virtual DbSet<namirnica> namirnica { get; set; }
        public virtual DbSet<namirnica_u_katalogu> namirnica_u_katalogu { get; set; }
        public virtual DbSet<narudzbenica> narudzbenica { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<uloga> uloga { get; set; }
        public virtual DbSet<zaposlenik> zaposlenik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<namirnica>()
                .Property(e => e.rok)
                .IsFixedLength();

            modelBuilder.Entity<namirnica_u_katalogu>()
                .Property(e => e.cijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<namirnica_u_katalogu>()
                .HasMany(e => e.iskoristenost_namirnice)
                .WithRequired(e => e.namirnica_u_katalogu)
                .HasForeignKey(e => e.namirnica_u_katalogu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<namirnica_u_katalogu>()
                .HasMany(e => e.namirnica)
                .WithRequired(e => e.namirnica_u_katalogu)
                .HasForeignKey(e => e.namirnica_u_katalogu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<namirnica_u_katalogu>()
                .HasMany(e => e.narudzbenica)
                .WithMany(e => e.namirnica_u_katalogu)
                .Map(m => m.ToTable("namirnica_narudzbenica"));

            modelBuilder.Entity<narudzbenica>()
                .Property(e => e.datum_kreiranja)
                .IsFixedLength();

            modelBuilder.Entity<narudzbenica>()
                .Property(e => e.sveukupan_iznos)
                .HasPrecision(19, 4);

            modelBuilder.Entity<uloga>()
                .HasMany(e => e.zaposlenik)
                .WithRequired(e => e.uloga)
                .HasForeignKey(e => e.uloga_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zaposlenik>()
                .HasMany(e => e.namirnica_u_katalogu)
                .WithRequired(e => e.zaposlenik)
                .HasForeignKey(e => e.zaposlenik_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zaposlenik>()
                .HasMany(e => e.narudzbenica)
                .WithRequired(e => e.zaposlenik)
                .HasForeignKey(e => e.zaposlenik_id)
                .WillCascadeOnDelete(false);
        }
    }
}
