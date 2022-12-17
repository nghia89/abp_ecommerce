using ABPEcommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPEcommerce.Configurations.Products
{
    public class ProductAttributeDateTimeConfiguration : IEntityTypeConfiguration<ProductAttributeDateTime>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeDateTime> builder)
        {
            builder.ToTable(ABPEcommerceConsts.DbTablePrefix + "ProductAttributeDateTimes");
            builder.HasKey(x => x.Id);



        }
    }
}
