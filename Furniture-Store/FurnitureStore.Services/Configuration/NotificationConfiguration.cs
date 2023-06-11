using System;
using FurnitureStore.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureStore.Services.Configuration
{
    public sealed class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasOne(n => n.Admin).WithMany(n => n.Notifications).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(u => u.Category).WithMany(u => u.Notifications).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

