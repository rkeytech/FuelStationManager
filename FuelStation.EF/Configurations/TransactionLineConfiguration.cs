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
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.HasKey(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.ID).ValueGeneratedOnAdd();

            builder.Property(transactionLine => transactionLine.Quantity).HasColumnType("decimal(10,3)");
            builder.Property(transactionLine => transactionLine.ItemPrice).HasColumnType("decimal(10,3)");
            builder.Property(transactionLine => transactionLine.NetValue).HasColumnType("decimal(10,3)");
            builder.Property(transactionLine => transactionLine.DiscountPercent).HasColumnType("decimal(6,2)");
            builder.Property(transactionLine => transactionLine.DiscountValue).HasColumnType("decimal(10,3)");
            builder.Property(transactionLine => transactionLine.TotalValue).HasColumnType("decimal(10,3)");
        }
    }
}
