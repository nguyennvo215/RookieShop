using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.BackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        }
    }
}
