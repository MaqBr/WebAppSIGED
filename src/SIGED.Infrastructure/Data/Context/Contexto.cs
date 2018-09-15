using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Context
{
    public class Contexto : DbContext
    {
        public Contexto(
            DbContextOptions<Contexto> options) 
            : base(options)
        {

        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<NivelEnsino> NiveisEnsinos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Estudante>(ConfigureEstudante);

            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Matricula>().ToTable("Matricula");
            modelBuilder.Entity<Estudante>().ToTable("Estudante");
            modelBuilder.Entity<Professor>().ToTable("Professor");
            modelBuilder.Entity<NivelEnsino>().ToTable("NivelEnsino");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
        }

        private void ConfigureEstudante(EntityTypeBuilder<Estudante> builder)
        {
            builder.ToTable("Estudante");

            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("estudante_hilo")
                .IsRequired();

            builder.Property(ci => ci.Nome)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(ci => ci.DataNacimento)
               .IsRequired(true);

            builder.Property(ci => ci.Peso)
                .IsRequired(true);

            builder.Property(ci => ci.Altura)
                .IsRequired(true);

            builder.Property(ci => ci.Foto)
                .IsRequired(false);

            builder.HasOne(ci => ci.NivelEnsino)
                .WithMany()
                .HasForeignKey(ci => ci.NivelEnsinoId);


            builder.HasOne(ci => ci.Endereco)
                .WithOne(x => x.Estudante);
                

        }




    }
}
