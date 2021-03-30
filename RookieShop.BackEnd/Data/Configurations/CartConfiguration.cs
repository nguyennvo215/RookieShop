using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.BackEnd.Data.Entities;

namespace RookieShop.BackEnd.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(o => o.ID);
            builder.Property(o => o.ID).IsRequired();
            builder.Property(o => o.UserID).IsRequired();
        }
    }
}
