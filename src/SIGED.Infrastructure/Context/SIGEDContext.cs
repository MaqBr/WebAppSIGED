using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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

            modelBuilder.Entity<Estudante>(ConfigureEstudante);
            //modelBuilder.Entity<CatalogBrand>(ConfigureCatalogBrand);
            //modelBuilder.Entity<CatalogType>(ConfigureCatalogType);
            //modelBuilder.Entity<CatalogItem>(ConfigureCatalogItem);
            //modelBuilder.Entity<Order>(ConfigureOrder);
            //modelBuilder.Entity<OrderItem>(ConfigureOrderItem);


            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Matricula>().ToTable("Matricula");
            modelBuilder.Entity<Estudante>().ToTable("Estudante");
            modelBuilder.Entity<Professor>().ToTable("Professor");
            modelBuilder.Entity<NivelEnsino>().ToTable("NivelEnsino");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
        }

        //private void ConfigureBasket(EntityTypeBuilder<Basket> builder)
        //{
        //    var navigation = builder.Metadata.FindNavigation(nameof(Basket.Items));

        //    navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
        //}

        private void ConfigureEstudante(EntityTypeBuilder<Estudante> builder)
        {
            builder.ToTable("Estudante");


            //builder.HasKey(k => k.Id)
            //    .HasName("Id");

            //builder.Property(p => p.Id)
            //    .IsRequired()
            //    .UseSqlServerIdentityColumn();


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

            //builder.HasOne(ci => ci.CatalogType)
            //    .WithMany()
            //    .HasForeignKey(ci => ci.CatalogTypeId);
        }

        //private void ConfigureCatalogBrand(EntityTypeBuilder<CatalogBrand> builder)
        //{
        //    builder.ToTable("CatalogBrand");

        //    builder.HasKey(ci => ci.Id);
        //http://www.talkingdotnet.com/use-hilo-to-generate-keys-with-entity-framework-core/
        //    builder.Property(ci => ci.Id)
        //       .ForSqlServerUseSequenceHiLo("catalog_brand_hilo")
        //       .IsRequired();

        //    builder.Property(cb => cb.Brand)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //}

        //private void ConfigureCatalogType(EntityTypeBuilder<CatalogType> builder)
        //{
        //    builder.ToTable("CatalogType");

        //    builder.HasKey(ci => ci.Id);

        //    builder.Property(ci => ci.Id)
        //       .ForSqlServerUseSequenceHiLo("catalog_type_hilo")
        //       .IsRequired();

        //    builder.Property(cb => cb.Type)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //}

        //private void ConfigureOrder(EntityTypeBuilder<Order> builder)
        //{
        //    var navigation = builder.Metadata.FindNavigation(nameof(Order.OrderItems));

        //    navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
        //https://medium.com/@fulviocanducci/microsoft-entity-framework-core-2-0-40168ef8e521
        //    builder.OwnsOne(o => o.ShipToAddress);
        //}

        //private void ConfigureOrderItem(EntityTypeBuilder<OrderItem> builder)
        //{
        //    builder.OwnsOne(i => i.ItemOrdered);
        //}


    }
}
