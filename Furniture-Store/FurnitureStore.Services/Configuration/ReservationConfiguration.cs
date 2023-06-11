using System;
using FurnitureStore.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureStore.Services.Configuration
{
    public sealed class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasOne(r => r.Customer).WithMany(u => u.Reservations).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(r => r.Product).WithMany(u => u.Reservations).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

