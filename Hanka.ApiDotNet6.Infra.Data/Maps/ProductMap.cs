using Hanka.ApiDotNet6.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hanka.ApiDotNet6.Infra.Data.Maps
{
  public class ProductMap : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> builder)
    {
      builder.ToTable("Produto");
      builder.HasKey(x => x.Id);

      builder.Property(x => x.Id)
        .HasColumnName("IdProduto")
        .UseIdentityColumn();

      builder.Property(x => x.CodeErp)
        .HasColumnName("IdPessoa")
        .UseIdentityColumn();

      builder.Property(x => x.CodeErp)
        .HasColumnName("CodeErp");

      builder.Property(x => x.Name)
        .HasColumnName("Nome");

      builder.Property(x => x.Price)
        .HasColumnName("Preco");

      builder.HasMany(x => x.Purchases)
        .WithOne(x => x.Product)
        .HasForeignKey(x => x.ProductId);

    }
  }

}
