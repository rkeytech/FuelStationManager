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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.ID);
            builder.Property(user => user.ID).ValueGeneratedOnAdd();

            builder.Property(user => user.Username).HasMaxLength(maxLength: 50);
            builder.Property(user => user.Password).HasMaxLength(maxLength: 50);

            builder.HasOne(employee => employee.Employee).WithOne()
                   .HasForeignKey<User>(user => user.EmployeeID)
                   .IsRequired(true);
        }
    }
}
