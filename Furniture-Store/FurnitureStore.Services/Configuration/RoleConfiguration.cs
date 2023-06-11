using System;
using FurnitureStore.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureStore.Services.Configuration
{
    public sealed class RolesConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            builder.HasData(RolesSeed.Data);
        }
    }
}

