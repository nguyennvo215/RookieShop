using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.BackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieShop.BackEnd.Data.Configurations
{
    public class UserInRoleConfiguration : IEntityTypeConfiguration<UserInRole>
    {
        public void Configure(EntityTypeBuilder<UserInRole> builder)
        {
            builder.HasKey(o => new { o.RoleID, o.UserID });

            builder
                .HasOne(o => o.Role)
                .WithMany(o => o.UserRoles)
                .HasForeignKey(o => o.RoleID);
            builder
                .HasOne(o => o.User)
                .WithMany(o => o.UserRoles)
                .HasForeignKey(o => o.UserID);
        }
    }
}
