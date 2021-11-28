﻿// <auto-generated />
using Hackaton.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hackaton.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Hackaton.App.Dominio.uGerencias", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("dias_novedad")
                        .HasColumnType("int");

                    b.Property<string>("fecha_novedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("texto_explicativo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("uGerencias");
                });
#pragma warning restore 612, 618
        }
    }
}
