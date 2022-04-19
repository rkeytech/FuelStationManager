using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class TransactionLine : BaseEntity
    {
        public uint TransactionID { get; set; }
        public uint ItemID { get; set; }
        public double Quantity { get; set; }
        public double ItemPrice { get; set; }
        public double NetValue { get; set; }
        public float DiscountPercent { get; set; }
        public double DiscountValue { get; set; }
        public double TotalValue { get; set; }

        // Entity Framework Navigation Objects
        public Item? Item { get; set; }
        public Transaction? Transaction { get; set; }

        public TransactionLine()
        {

        }
    }
}
