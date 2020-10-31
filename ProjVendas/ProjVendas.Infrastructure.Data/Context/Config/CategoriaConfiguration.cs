using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjVendas.Domain.Entities;

namespace ProjVendas.Infrastructure.Data.Context.Config
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}