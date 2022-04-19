using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(item => item.ID);
            builder.Property(item => item.ID).ValueGeneratedOnAdd();

            builder.Property(item => item.Code).HasMaxLength(maxLength: 50);
            builder.Property(item => item.Description).HasMaxLength(maxLength: 250);
            builder.Property(item => item.Cost).HasColumnType("decimal(10,3)");
            builder.Property(item => item.Price).HasColumnType("decimal(10,3)");
        }
    }
}
