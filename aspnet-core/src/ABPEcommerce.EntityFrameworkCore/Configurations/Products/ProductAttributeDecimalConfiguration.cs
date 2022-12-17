using ABPEcommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPEcommerce.Configurations.Products
{
    public class ProductAttributeDecimalConfiguration : IEntityTypeConfiguration<ProductAttributeDecimal>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeDecimal> builder)
        {
            builder.ToTable(ABPEcommerceConsts.DbTablePrefix + "ProductAttributeDecimals");
            builder.HasKey(x => x.Id);
        }
    }
}
