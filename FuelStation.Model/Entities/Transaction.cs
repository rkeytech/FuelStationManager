using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class Transaction : BaseEntity
    {
        public DateTime Date { get; set; }
        public uint EmployeeID { get; set; }
        public uint CustomerID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public double TotalValue { get; set; }

        // Entity Framework Navigation Objects
        public Employee? Employee { get; set; }
        public Customer? Customer { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }

        public Transaction()
        {
            Date = DateTime.Now;
            TransactionLines = new List<TransactionLine>();
        }
    }
}
