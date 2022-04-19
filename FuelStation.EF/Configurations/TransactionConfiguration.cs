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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).ValueGeneratedOnAdd();

            builder.Property(transaction => transaction.TotalValue).HasColumnType("decimal(10,3)");

            builder.HasMany(transaction => transaction.TransactionLines)
                   .WithOne(transactionLine => transactionLine.Transaction)
                   .HasForeignKey(transactionLine => transactionLine.TransactionID)
                   .IsRequired(true);
            builder.HasOne(transaction => transaction.Employee)
                   .WithMany(employee => employee.Transactions)
                   .HasForeignKey(transaction => transaction.EmployeeID)
                   .IsRequired(true)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(transaction => transaction.Customer)
                   .WithMany(customer => customer.Transactions)
                   .HasForeignKey(transaction => transaction.CustomerID)
                   .IsRequired(true)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
