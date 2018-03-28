using Microsoft.EntityFrameworkCore;
using SIGED.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.Infrastructure.Context
{
    public class SIGEDContext : DbContext
    {
        public SIGEDContext(
            DbContextOptions<SIGEDContext> options) 
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
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Matricula>().ToTable("Matricula");
            modelBuilder.Entity<Estudante>().ToTable("Estudante");
            modelBuilder.Entity<Professor>().ToTable("Professor");
            modelBuilder.Entity<NivelEnsino>().ToTable("NivelEnsino");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
        }
    }
}
