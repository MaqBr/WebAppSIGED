﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SIGED.Infrastructure.Context;

namespace SIGED.Infrastructure.Migrations
{
    [DbContext(typeof(SIGEDContext))]
    partial class SIGEDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.estudante_hilo", "'estudante_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CursoNome");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP");

                    b.Property<string>("Endereco1");

                    b.Property<string>("Endereco2");

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Estado");

                    b.Property<int>("EstudanteId");

                    b.HasKey("Id");

                    b.HasIndex("EstudanteId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.Estudante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "estudante_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<decimal>("Altura");

                    b.Property<DateTime>("DataNacimento");

                    b.Property<string>("Foto");

                    b.Property<int>("NivelEnsinoId");

                    b.Property<int?>("NivelEnsinoId1");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<decimal>("Peso");

                    b.HasKey("Id");

                    b.HasIndex("NivelEnsinoId");

                    b.HasIndex("NivelEnsinoId1");

                    b.ToTable("Estudante");
                });

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CursoId");

                    b.Property<int>("EstudanteId");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("EstudanteId");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.NivelEnsino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<int>("EstudanteId");

                    b.Property<int>("ProfessorId");

                    b.HasKey("Id");

                    b.ToTable("NivelEnsino");
                });

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NivelEnsinoId");

                    b.Property<string>("ProfessorNome");

                    b.Property<string>("TipoProfessor");

                    b.HasKey("Id");

                    b.HasIndex("NivelEnsinoId");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.Endereco", b =>
                {
                    b.HasOne("SIGED.ApplicationCore.Entity.Estudante", "Estudante")
                        .WithOne("Endereco")
                        .HasForeignKey("SIGED.ApplicationCore.Entity.Endereco", "EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.Estudante", b =>
                {
                    b.HasOne("SIGED.ApplicationCore.Entity.NivelEnsino", "NivelEnsino")
                        .WithMany()
                        .HasForeignKey("NivelEnsinoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SIGED.ApplicationCore.Entity.NivelEnsino")
                        .WithMany("Estudantes")
                        .HasForeignKey("NivelEnsinoId1");
                });

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.Matricula", b =>
                {
                    b.HasOne("SIGED.ApplicationCore.Entity.Curso", "Curso")
                        .WithMany("Matriculas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SIGED.ApplicationCore.Entity.Estudante", "Estudante")
                        .WithMany("Matriculas")
                        .HasForeignKey("EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SIGED.ApplicationCore.Entity.Professor", b =>
                {
                    b.HasOne("SIGED.ApplicationCore.Entity.NivelEnsino", "NivelEnsino")
                        .WithMany("Professores")
                        .HasForeignKey("NivelEnsinoId");
                });
#pragma warning restore 612, 618
        }
    }
}
