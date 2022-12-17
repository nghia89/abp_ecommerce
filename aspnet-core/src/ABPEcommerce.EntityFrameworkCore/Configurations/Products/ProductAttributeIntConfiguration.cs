using ABPEcommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPEcommerce.Configurations.Products
{
    public class ProductAttributeIntConfiguration : IEntityTypeConfiguration<ProductAttributeInt>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeInt> builder)
        {
            builder.ToTable(ABPEcommerceConsts.DbTablePrefix + "ProductAttributeInts");
            builder.HasKey(x => x.Id);
        }
    }
}
