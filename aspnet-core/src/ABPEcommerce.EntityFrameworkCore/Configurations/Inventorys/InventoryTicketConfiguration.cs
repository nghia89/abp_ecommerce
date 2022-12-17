﻿using ABPEcommerce.InventoryTickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPEcommerce.Configurations.Inventorys
{
    public class InventoryTicketConfiguration : IEntityTypeConfiguration<InventoryTicket>
    {
        public void Configure(EntityTypeBuilder<InventoryTicket> builder)
        {
            builder.ToTable(ABPEcommerceConsts.DbTablePrefix + "InventoryTickets");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();
        }
    }
}
