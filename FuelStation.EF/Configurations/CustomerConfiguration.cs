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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.ID).ValueGeneratedOnAdd();

            builder.Property(customer => customer.Name).HasMaxLength(maxLength: 250);
            builder.Property(customer => customer.Surname).HasMaxLength(maxLength: 250);
            builder.Property(customer => customer.CardNumber).HasMaxLength(maxLength: 50);

            builder.HasIndex(customer => customer.CardNumber).IsUnique(true);
        }
    }
}
