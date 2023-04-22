﻿// <auto-generated />
using System;
using GestioneSagre.Utility.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestioneSagre.Utility.Migrations
{
    [DbContext(typeof(UtilityDbContext))]
    partial class UtilityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GestioneSagre.Shared.Entities.Utility.ScontrinoPagato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ScontrinoPagato", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("08db403c-b0d9-066c-753a-8e4b8c020f59"),
                            Value = "Pagato"
                        },
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0681-753a-8e4b8c020f5a"),
                            Value = "Non pagato"
                        });
                });

            modelBuilder.Entity("GestioneSagre.Shared.Entities.Utility.ScontrinoStato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ScontrinoStato", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0dd8-753a-8e4b8c020f5b"),
                            Value = "Aperto"
                        },
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0ddb-753a-8e4b8c020f5c"),
                            Value = "In elaborazione"
                        },
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0dde-753a-8e4b8c020f5d"),
                            Value = "Da incassare"
                        },
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0de0-753a-8e4b8c020f5e"),
                            Value = "Chiuso"
                        },
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0de3-753a-8e4b8c020f5f"),
                            Value = "Annullato"
                        });
                });

            modelBuilder.Entity("GestioneSagre.Shared.Entities.Utility.TipoCliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoCliente", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0e63-753a-8e4b8c020f60"),
                            Value = "Cliente"
                        },
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0e66-753a-8e4b8c020f61"),
                            Value = "Staff"
                        });
                });

            modelBuilder.Entity("GestioneSagre.Shared.Entities.Utility.TipoPagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoPagamento", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0f49-753a-8e4b8c020f64"),
                            Value = "Contanti"
                        },
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0f4c-753a-8e4b8c020f65"),
                            Value = "Carta di credito"
                        },
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0f4f-753a-8e4b8c020f66"),
                            Value = "Carta di debito"
                        });
                });

            modelBuilder.Entity("GestioneSagre.Shared.Entities.Utility.TipoScontrino", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoScontrino", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0ed2-753a-8e4b8c020f62"),
                            Value = "Pagamento"
                        },
                        new
                        {
                            Id = new Guid("08db403c-b0d9-0ed5-753a-8e4b8c020f63"),
                            Value = "Omaggio"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
