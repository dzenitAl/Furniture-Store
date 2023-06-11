using System;
using FurnitureStore.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureStore.Services.Configuration
{
    public sealed class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasOne(r => r.Admin).WithMany(u => u.Reports).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

