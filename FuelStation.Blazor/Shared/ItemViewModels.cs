using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class ItemListViewModel
    {
        public uint ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
    }
    
    public class ItemEditViewModel
    {
        public uint ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public List<string> Messages { get; set; } = new();

    }
}
