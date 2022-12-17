using ABPEcommerce.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPEcommerce.Configurations.Promotions
{
    public class PromotionManufacturerConfiguration : IEntityTypeConfiguration<PromotionManufacturer>
    {
        public void Configure(EntityTypeBuilder<PromotionManufacturer> builder)
        {
            builder.ToTable(ABPEcommerceConsts.DbTablePrefix + "PromotionManufacturers");
            builder.HasKey(x => x.Id);
        }
    }
}
