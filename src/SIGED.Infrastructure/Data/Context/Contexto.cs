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

        public DbSet<CalculoBasal> CalculosBasal { get; set; }
        public DbSet<CaracterizacaoArea> CaracterizacoesAreas { get; set; }
        public DbSet<ColetaAmostra> ColetasAmostras { get; set; }
        public DbSet<MateriaisEquipamentos> MateriaisEquipamentos { get; set; }
        public DbSet<Pesquisador> Pesquisadores { get; set; }
        public DbSet<ProcessamentoAmostra> ProcessamentoAmostras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
