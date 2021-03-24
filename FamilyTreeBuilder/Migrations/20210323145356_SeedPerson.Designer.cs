﻿// <auto-generated />
using System;
using FamilyTreeBuilder.ModelsGenerated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FamilyTreeBuilder.Migrations
{
    [DbContext(typeof(FamilyTreeContext))]
    [Migration("20210323145356_SeedPerson")]
    partial class SeedPerson
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:btree_gin", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:btree_gist", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:citext", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:cube", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:dblink", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:dict_int", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:dict_xsyn", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:earthdistance", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:fuzzystrmatch", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:hstore", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:intarray", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:ltree", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:pg_stat_statements", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:pg_trgm", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:pgcrypto", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:pgrowlocks", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:pgstattuple", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:tablefunc", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:unaccent", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:xml2", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FamilyTreeBuilder.ModelsGenerated.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnName("birth_date")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnName("death_date")
                        .HasColumnType("date");

                    b.Property<int?>("Father")
                        .HasColumnName("father")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("character varying");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("character varying");

                    b.Property<int?>("Mother")
                        .HasColumnName("mother")
                        .HasColumnType("integer");

                    b.Property<string>("Sex")
                        .HasColumnName("sex")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.HasIndex("Father");

                    b.HasIndex("Mother");

                    b.ToTable("person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1950, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Hommer",
                            LastName = "Simpson"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1955, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Marge",
                            LastName = "Simpson"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1970, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bart",
                            LastName = "Simpson"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1980, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lisa",
                            LastName = "Simpson"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1987, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Maggie",
                            LastName = "Simpson"
                        });
                });

            modelBuilder.Entity("FamilyTreeBuilder.ModelsGenerated.Person", b =>
                {
                    b.HasOne("FamilyTreeBuilder.ModelsGenerated.Person", "FatherNavigation")
                        .WithMany("InverseFatherNavigation")
                        .HasForeignKey("Father")
                        .HasConstraintName("person_father_fkey");

                    b.HasOne("FamilyTreeBuilder.ModelsGenerated.Person", "MotherNavigation")
                        .WithMany("InverseMotherNavigation")
                        .HasForeignKey("Mother")
                        .HasConstraintName("person_mother_fkey");
                });
#pragma warning restore 612, 618
        }
    }
}
