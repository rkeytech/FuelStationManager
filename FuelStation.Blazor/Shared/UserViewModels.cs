using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class UserAuthenticatedViewModel
    {
        public string? Username { get; set; }
        public EmployeeTypeEnum? EmployeeType { get; set; }
        public List<string> Messages { get; set; } = new();
        public bool IsAuthed { get; set; }
    }
}
