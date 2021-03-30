using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.BackEnd.Data.Entities;

namespace RookieShop.BackEnd.Data.Configurations
{
    public class RetailDetailConfiguration : IEntityTypeConfiguration<RetailDetail>
    {
        public void Configure(EntityTypeBuilder<RetailDetail> builder)
        {
            builder.HasKey(o => o.ID);
            builder.Property(o => o.ID).UseIdentityColumn();
            builder.Property(o => o.CartID).IsRequired();
        }
    }
}
