﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    [DbContext(typeof(TablaDbContext))]
    [Migration("20190730001656_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Aula", b =>
                {
                    b.Property<int>("aulaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aula");

                    b.Property<int>("capacidad");

                    b.Property<string>("seccion");

                    b.HasKey("aulaId");

                    b.ToTable("Aula");
                });

            modelBuilder.Entity("Model.Estudiante", b =>
                {
                    b.Property<int>("estudianteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido");

                    b.Property<string>("curso");

                    b.Property<string>("nombre");

                    b.HasKey("estudianteId");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("Model.Maestro", b =>
                {
                    b.Property<int>("maestroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido");

                    b.Property<string>("materia");

                    b.Property<string>("nombre");

                    b.HasKey("maestroId");

                    b.ToTable("Maestro");
                });

            modelBuilder.Entity("Model.Materia", b =>
                {
                    b.Property<int>("materiaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("credito");

                    b.Property<string>("materia");

                    b.HasKey("materiaId");

                    b.ToTable("Materia");
                });
#pragma warning restore 612, 618
        }
    }
}
