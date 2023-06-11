﻿using System;
using FurnitureStore.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureStore.Services.Configuration
{
    public sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Username).IsRequired().HasMaxLength(254);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(254);
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.HasOne(u => u.City).WithMany(u => u.Users).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

