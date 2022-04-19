using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class TransactionLineViewModel
    {
        public uint ID { get; set; }
        public uint ItemID { get; set; }
        public string ItemName { get; set; }
        public double Quantity { get; set; }
        public double ItemPrice { get; set; }
        public ItemTypeEnum? ItemType { get; set; }
        public double NetValue { get; set; }
        public float DiscountPercent { get; set; }
        public double DiscountValue { get; set; }
        public double TotalValue { get; set; }
    }
    
}
