using ABPEcommerce.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPEcommerce.Configurations.Promotions
{
    public class PromotionCategoryConfiguration : IEntityTypeConfiguration<PromotionCategory>
    {
        public void Configure(EntityTypeBuilder<PromotionCategory> builder)
        {
            builder.ToTable(ABPEcommerceConsts.DbTablePrefix + "PromotionCategories");
            builder.HasKey(x => x.Id);
        }
    }
}
