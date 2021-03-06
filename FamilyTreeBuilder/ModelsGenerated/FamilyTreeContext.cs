using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FamilyTreeBuilder.ModelsGenerated
{
    public partial class FamilyTreeContext : DbContext
    {
        public FamilyTreeContext()
        {
        }

        public FamilyTreeContext(DbContextOptions<FamilyTreeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                                                                                                                    
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=tuffi.db.elephantsql.com;Database=gwxsitni;User Id=gwxsitni;Password=5nrn1FaGX8p4aCSVf2CYrRLZ4bU7enF_;Port=5432");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("btree_gin")
                .HasPostgresExtension("btree_gist")
                .HasPostgresExtension("citext")
                .HasPostgresExtension("cube")
                .HasPostgresExtension("dblink")
                .HasPostgresExtension("dict_int")
                .HasPostgresExtension("dict_xsyn")
                .HasPostgresExtension("earthdistance")
                .HasPostgresExtension("fuzzystrmatch")
                .HasPostgresExtension("hstore")
                .HasPostgresExtension("intarray")
                .HasPostgresExtension("ltree")
                .HasPostgresExtension("pg_stat_statements")
                .HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("pgrowlocks")
                .HasPostgresExtension("pgstattuple")
                .HasPostgresExtension("tablefunc")
                .HasPostgresExtension("unaccent")
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("xml2")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Person>().HasData(
                new Person {Id = 1, FirstName = "Hommer", LastName = "Simpson", BirthDate = new DateTime(1950, 06, 12) },
                new Person {Id = 2, FirstName = "Marge", LastName = "Simpson", BirthDate = new DateTime(1955, 07, 03) },
                new Person {Id = 3, FirstName = "Bart", LastName = "Simpson", BirthDate = new DateTime(1970, 03, 23) },
                new Person {Id = 4, FirstName = "Lisa", LastName = "Simpson", BirthDate = new DateTime(1980, 08, 09) },
                new Person {Id = 5, FirstName = "Maggie", LastName = "Simpson", BirthDate = new DateTime(1987, 01, 12) }
            );

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.DeathDate)
                    .HasColumnName("death_date")
                    .HasColumnType("date");

                entity.Property(e => e.Father).HasColumnName("father");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("character varying");

                entity.Property(e => e.Mother).HasColumnName("mother");

                entity.HasOne(d => d.FatherNavigation)
                    .WithMany(p => p.InverseFatherNavigation)
                    .HasForeignKey(d => d.Father)
                    .HasConstraintName("person_father_fkey");

                entity.HasOne(d => d.MotherNavigation)
                    .WithMany(p => p.InverseMotherNavigation)
                    .HasForeignKey(d => d.Mother)
                    .HasConstraintName("person_mother_fkey");
            });
        }
    }
}
