using System;
using FurnitureStore.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureStore.Services.Configuration
{
    public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasOne(r => r.Customer).WithMany(u => u.Orders).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

