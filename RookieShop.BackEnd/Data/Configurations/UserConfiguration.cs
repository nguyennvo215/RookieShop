using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.BackEnd.Data.Entities;

namespace RookieShop.BackEnd.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(o => o.ID);
            builder.Property(o => o.ID).UseIdentityColumn();
            builder.Property(o => o.Username).IsRequired();
            builder.Property(o => o.Password).IsRequired();
            builder.Property(o => o.Email).IsRequired();
            builder.Property(o => o.Address).IsRequired();
        }
    }
}
