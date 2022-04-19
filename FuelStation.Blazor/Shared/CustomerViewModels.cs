using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class CustomerListViewModel
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
    }
    
    public class CustomerEditViewModel
    {
        public uint ID { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Surname { get; set; } = String.Empty;
        public string CardNumber { get; set; } = $"A{Guid.NewGuid().ToString().Substring(0, 8)}";
        public List<string> Messages { get; set; } = new();
    }
}
