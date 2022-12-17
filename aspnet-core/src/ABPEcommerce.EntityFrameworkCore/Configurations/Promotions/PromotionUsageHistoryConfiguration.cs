using ABPEcommerce.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPEcommerce.Configurations.Promotions
{
    public class PromotionUsageHistoryConfiguration : IEntityTypeConfiguration<PromotionUsageHistory>
    {
        public void Configure(EntityTypeBuilder<PromotionUsageHistory> builder)
        {
            builder.ToTable(ABPEcommerceConsts.DbTablePrefix + "PromotionUsageHistories");
            builder.HasKey(x => x.Id);
        }
    }
}
