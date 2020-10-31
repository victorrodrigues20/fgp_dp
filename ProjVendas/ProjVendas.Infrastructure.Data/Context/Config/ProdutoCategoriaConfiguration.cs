using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjVendas.Domain.Entities;

namespace ProjVendas.Infrastructure.Data.Context.Config
{
    public class ProdutoCategoriaConfiguration : IEntityTypeConfiguration<ProdutoCategoria>
    {
        public void Configure(EntityTypeBuilder<ProdutoCategoria> builder)
        {
            #region ProdutoCategoria

            //a Gera Chave Primaria Composta
            builder.HasKey(bc => new { bc.CategoriaID, bc.ProdutoID });

            builder.HasOne(bc => bc.Categoria)
                .WithMany(b => b.ProdCategoria)
                .HasForeignKey(bc => bc.CategoriaID);

            builder.HasOne(bc => bc.Produto)
                .WithMany(c => c.ProdCategoria)
                .HasForeignKey(bc => bc.ProdutoID);

            #endregion
        }
    }
}