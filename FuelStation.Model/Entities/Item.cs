using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class Item : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }

        public Item()
        {
            Code = string.Empty;
            Description = string.Empty;
        }

    }
}
