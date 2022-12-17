using ABPEcommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPEcommerce.Configurations.Products
{
    public class ProductAttributeTextConfiguration : IEntityTypeConfiguration<ProductAttributeText>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeText> builder)
        {
            builder.ToTable(ABPEcommerceConsts.DbTablePrefix + "ProductAttributeTexts");
            builder.HasKey(x => x.Id);
        }
    }
}
