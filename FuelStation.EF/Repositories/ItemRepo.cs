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
    public class ItemRepo : IEntityRepo<Item>
    {
        private readonly FuelStationContext _context;

        public ItemRepo(FuelStationContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Item entity)
        {
            if (entity.ID != 0)
                throw new ArgumentException("The values of ID field must be auto generated");
            _context.Items.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(uint id)
        {
            var foundItem = await _context.Items.SingleOrDefaultAsync(item => item.ID == id);
            if (foundItem is null)
                throw new KeyNotFoundException($"Item with id '{id}' was not found in the database");
            _context.Items.Remove(foundItem);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _context.Items.AsNoTracking().ToListAsync();
        }

        public Task<Item> GetByAttrAsync(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<Item> GetByIdAsync(uint id)
        {
            return await _context.Items.AsNoTracking().SingleOrDefaultAsync(item => item.ID == id);
        }

        public async Task UpdateAsync(uint id, Item entity)
        {
            var foundItem = await _context.Items.SingleOrDefaultAsync(item => item.ID == id);
            if (foundItem is null)
                throw new KeyNotFoundException($"Item with id '{id}' was not found in the database");
            foundItem.Code = entity.Code;
            foundItem.Description = entity.Description;
            foundItem.ItemType = entity.ItemType;
            foundItem.Cost = entity.Cost;
            foundItem.Price = entity.Price;
            await _context.SaveChangesAsync();
        }
    }
}
