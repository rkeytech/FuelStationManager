using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class Employee : Person
    {
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public double SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

        // Entity Framework Navigation Objects
        public List<Transaction>? Transactions { get; set; }

        public Employee()
        {

        }
    }
}
