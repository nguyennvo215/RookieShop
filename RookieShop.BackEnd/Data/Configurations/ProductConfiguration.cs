using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.BackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieShop.BackEnd.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(o => o.ID);
            builder.Property(o => o.ID).UseIdentityColumn();
            builder.Property(o => o.ProductName).IsRequired();
            builder.Property(o => o.ProductPrice).IsRequired();
            builder.Property(o => o.ProductFullDescription).HasColumnType("ntext");
            builder.Property(o => o.ProductShortDescription).HasColumnType("ntext");
        }
    }
}
