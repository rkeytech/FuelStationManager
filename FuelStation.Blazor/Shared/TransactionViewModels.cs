using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class TransactionListViewModel
    {
        public uint ID { get; set; }
        public DateTime Date { get; set; }
        public string Employee { get; set; }
        public string Customer { get; set; }
        public string PaymentMethod { get; set; }
        public double TotalValue { get; set; }
    }
    
    public class TransactionEditViewModel
    {
        public uint ID { get; set; }
        public DateTime Date { get; set; }
        public uint EmployeeID { get; set; }
        public uint CustomerID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public double TotalValue { get; set; }
        public List<TransactionLineViewModel> TransactionLines { get; set; } = new();
        public List<string> Messages { get; set; } = new();


    }
}
