using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class EmployeeListViewModel
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double SalaryPerMonth { get; set; }
        public string EmployeeType { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
    }
    
    public class EmployeeEditViewModel
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public List<string> Messages { get; set; } = new();
    }
}
