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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID).ValueGeneratedOnAdd();

            builder.Property(employee => employee.Name).HasMaxLength(maxLength: 250);
            builder.Property(employee => employee.Surname).HasMaxLength(maxLength: 250);
            builder.Property(employee => employee.SalaryPerMonth).HasColumnType("decimal(10,2)");
            builder.Property(employee => employee.HireDateStart).HasColumnType("date");
            builder.Property(employee => employee.HireDateEnd).HasColumnType("date").IsRequired(false);
        }
    }
}
