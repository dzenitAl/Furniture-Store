using System;
using FurnitureStore.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureStore.Services.Configuration
{
    public sealed class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasOne(p => p.Category).WithMany(c => c.Subcategories).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

