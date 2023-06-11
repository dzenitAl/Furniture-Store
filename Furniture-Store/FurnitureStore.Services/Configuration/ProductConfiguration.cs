using System;
using FurnitureStore.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureStore.Services.Configuration
{
    public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasOne(p => p.Category).WithMany(c => c.Products).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Subcategory).WithMany(c => c.Products).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

