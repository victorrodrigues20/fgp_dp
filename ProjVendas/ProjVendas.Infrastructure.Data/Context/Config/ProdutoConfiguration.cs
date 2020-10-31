using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjVendas.Domain.Entities;

namespace ProjVendas.Infrastructure.Data.Context.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}