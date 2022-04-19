using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Handlers
{
    public class TransactionHandler
    {
        public TransactionHandler()
        {

        }

        public double CalculateNetValue(double quantity, double price)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be a non zero positive number");
            if (price <= 0) throw new ArgumentException("Price must be a non zero positive number");
            return Math.Round(quantity * price, 2);
        }

        public double CalculateDiscountValue(double netValue, double discountPercent)
        {
            if (netValue <= 0) throw new ArgumentException("Net Value must be a non zero positive value");
            if (discountPercent < 0) throw new ArgumentException("Discount Percent must not be a negative value");
            return Math.Round(netValue * discountPercent, 2);
        }

        public double CalculateLineTotalValue(double discountValue, double netValue)
        {
            if (discountValue < 0) throw new ArgumentException("Discount value must not be a negative value");
            if (netValue <= 0) throw new ArgumentException("Net Value must be a non zero positive value");
            return Math.Round(netValue - discountValue, 2);
        }
        
        public double CalculateTransactionTotalValue(List<double> linesTotalValues)
        {
            return Math.Round(linesTotalValues.Sum(), 2);
        }

        public double ApplyTenPercentDiscount(double netValue, double discount, ItemTypeEnum type)
        {
            if (netValue <= 0) throw new ArgumentException("Net Value must be a non zero positive value");
            if (discount < 0) throw new ArgumentException("Discount must be a positive value");
            if (type == ItemTypeEnum.Fuel && netValue > 20)
            {
                return CalculateDiscountValue(netValue, discount);
            }
            return 0;
        }

        public bool CheckCardPaymentAvail(double totalValue)
        {
            if (totalValue < 0) throw new ArgumentException("Total Value must be a positive number");
            if (totalValue > 50)
                return false;
            return true;
        }
    }
}
