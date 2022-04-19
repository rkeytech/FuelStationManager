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
    public class UserRepo : IEntityRepo<User>
    {
        private readonly FuelStationContext _context;

        public UserRepo(FuelStationContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User entity)
        {
            if (entity.ID != 0)
                throw new ArgumentException("The values of ID field must be auto generated");
            _context.Users.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(uint id)
        {
            var foundUser = await _context.Users.SingleOrDefaultAsync(user => user.ID == id);
            if (foundUser is null)
                throw new KeyNotFoundException($"User with id '{id}' was not found in the database");
            _context.Users.Remove(foundUser);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.AsNoTracking().Include(user => user.Employee).ToListAsync();
        }

        public Task<User> GetByAttrAsync(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByIdAsync(uint id)
        {
            return await _context.Users.AsNoTracking().SingleOrDefaultAsync(user => user.ID == id);
        }

        public async Task UpdateAsync(uint id, User entity)
        {
            var foundUser = await _context.Users.SingleOrDefaultAsync(user => user.ID == id);
            if (foundUser is null)
                throw new KeyNotFoundException($"User with id '{id}' was not found in the database");
            foundUser.Username = entity.Username;
            foundUser.Password = entity.Password;
            foundUser.IsActive = entity.IsActive;
            await _context.SaveChangesAsync();
        }
    }
}
