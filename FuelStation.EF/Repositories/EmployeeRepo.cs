using FuelStation.EF.Contexts;
using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        private readonly FuelStationContext _context;

        public EmployeeRepo(FuelStationContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Employee entity)
        {
            if (entity.ID != 0)
                throw new ArgumentException("The values of ID field must be auto generated");
            _context.Employees.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(uint id)
        {
            var foundEmployee = await _context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Employee with id '{id}' was not found in the database");
            _context.Employees.Remove(foundEmployee);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.AsNoTracking().ToListAsync();
        }

        public Task<Employee> GetByAttrAsync(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> GetByIdAsync(uint id)
        {
            return await _context.Employees.AsNoTracking().SingleOrDefaultAsync(employee => employee.ID == id);
        }

        public async Task UpdateAsync(uint id, Employee entity)
        {
            var foundEmployee = await _context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Employee with id '{id}' was not found in the database");
            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.EmployeeType = entity.EmployeeType;
            foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            foundEmployee.HireDateStart = entity.HireDateStart;
            foundEmployee.HireDateEnd = entity.HireDateEnd;
            await _context.SaveChangesAsync();
        }
    }
}
