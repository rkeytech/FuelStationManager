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
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        private readonly FuelStationContext _context;

        public TransactionRepo(FuelStationContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Transaction entity)
        {
            if (entity.ID != 0)
                throw new ArgumentException("The values of ID field must be auto generated");
            _context.Transactions.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(uint id)
        {
            var foundTransaction = await _context.Transactions.SingleOrDefaultAsync(transaction => transaction.ID == id);
            if (foundTransaction is null)
                throw new KeyNotFoundException($"Transaction with id '{id}' was not found in the database");
            _context.Transactions.Remove(foundTransaction);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await _context.Transactions.AsNoTracking()
                                              .Include(transaction => transaction.Employee)
                                              .Include(transaction => transaction.Customer)
                                              .Include(transaction => transaction.TransactionLines)
                                              .ThenInclude(transactionLine => transactionLine.Item)
                                              .ToListAsync();
        }

        public Task<Transaction> GetByAttrAsync(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<Transaction> GetByIdAsync(uint id)
        {
            return await _context.Transactions.AsNoTracking()
                                              .Include(transaction => transaction.Employee)
                                              .Include(transaction => transaction.Customer)
                                              .Include(transaction => transaction.TransactionLines)
                                              .ThenInclude(transactionLine => transactionLine.Item)
                                              .SingleOrDefaultAsync(transaction => transaction.ID == id);
        }

        public async Task UpdateAsync(uint id, Transaction entity)
        {
            var foundTransaction = await _context.Transactions.Include(transaction => transaction.TransactionLines)
                                                              .Include(transaction => transaction.Employee)
                                                              .Include(transaction => transaction.Customer)
                                                              .SingleOrDefaultAsync(transaction => transaction.ID == id);
            if (foundTransaction is null)
                throw new KeyNotFoundException($"Transaction with id '{id}' was not found in the database");
            foundTransaction.EmployeeID = entity.EmployeeID;
            foundTransaction.CustomerID = entity.CustomerID;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            foundTransaction.TotalValue = entity.TotalValue;
            foundTransaction.TransactionLines = entity.TransactionLines;
            await _context.SaveChangesAsync();
        }
    }
}
