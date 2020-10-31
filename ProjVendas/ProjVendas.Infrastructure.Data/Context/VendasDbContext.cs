using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProjVendas.Domain.Entities;
using ProjVendas.Infrastructure.Data.Context.Config;

namespace ProjVendas.Infrastructure.Data.Context
{
    public class VendasDbContext : DbContext
    {
        public VendasDbContext(DbContextOptions<VendasDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.ApplyConfiguration(new CategoriaConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // // modelBuilder.Entity<Categoria>()
            // //     .Property(p => p.Nome)
            // //     .IsRequired();
        }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Produto> Produto { get; set; }  

        public DbSet<ProdutoCategoria> ProdutoCategoria { get; set; }

    }
}