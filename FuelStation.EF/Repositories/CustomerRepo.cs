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
    public class CustomerRepo : IEntityRepo<Customer>
    {
        private readonly FuelStationContext _context;

        public CustomerRepo(FuelStationContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Customer entity)
        {
            if (entity.ID != 0)
                throw new ArgumentException("The values of ID field must be auto generated");
            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(uint id)
        {
            var foundCustomer = await _context.Customers.SingleOrDefaultAsync(customer => customer.ID == id);
            if (foundCustomer is null)
                throw new KeyNotFoundException($"Customer with id '{id}' was not found in the database");
            _context.Customers.Remove(foundCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.AsNoTracking().ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(uint id)
        {
            return await _context.Customers.AsNoTracking().SingleOrDefaultAsync(customer => customer.ID == id);
        }
        
        public async Task UpdateAsync(uint id, Customer entity)
        {
            var foundCustomer = await _context.Customers.SingleOrDefaultAsync(customer => customer.ID == id);
            if (foundCustomer is null)
                throw new KeyNotFoundException($"Customer with id '{id}' was not found in the database");
            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;
            foundCustomer.CardNumber = entity.CardNumber;
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetByAttrAsync(string value)
        {
            return await _context.Customers.AsNoTracking().SingleOrDefaultAsync(customer => customer.CardNumber == value);
        }
    }
}
