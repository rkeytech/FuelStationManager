using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public uint EmployeeID { get; set; }

        // Entity Framework Navigation Objects
        public Employee Employee { get; set; }

        public User()
        {
            Username = string.Empty;
            Password = string.Empty;
            IsActive = true;
        }
    }
}
