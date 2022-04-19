using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Model.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtilityController : ControllerBase
    {
        private readonly IEntityRepo<User> _userRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly LedgerHandler _ledgerHandler;

        public UtilityController(IEntityRepo<User> userRepo, IEntityRepo<Transaction> transactionRepo,
                                 IEntityRepo<Employee> employeeRepo, LedgerHandler ledgerHandler)
        {
            _userRepo = userRepo;
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _ledgerHandler = ledgerHandler;
        }

        [HttpGet("auth/{username}/{password}")]
        public async Task<UserAuthenticatedViewModel> Get(string username, string password)
        {
            var users = await _userRepo.GetAllAsync();
            var foundUser = users.SingleOrDefault(u => u.Username == username && 
                                                      u.Password == password);
            if (foundUser is not null)
            {
                return new UserAuthenticatedViewModel()
                {
                    Username = foundUser.Username,
                    EmployeeType = foundUser.Employee.EmployeeType,
                    IsAuthed = true
                };
            }
            return new UserAuthenticatedViewModel()
            {
                Messages = new List<string>
                {
                    "Username or password don't match. Please try again."
                }
            };
        }
        
        [HttpGet("ledger/{year}/{month}")]
        public async Task<MonthlyLedgerViewModel> Get(int year, int month)
        {
            var ledger = new MonthlyLedgerViewModel()
            {
                Year = year,
                Month = month
            };
            var transactionsInMonth = (await _transactionRepo.GetAllAsync())
                                                             .Where(transaction => transaction.Date.Year == ledger.Year &&
                                                                                   transaction.Date.Month == ledger.Month);
            var employeesInMonth = (await _employeeRepo.GetAllAsync())
                                                       .Where(employee => employee.HireDateStart.Year <= ledger.Year &&
                                                                          employee.HireDateStart.Month <= ledger.Month);
            ledger.Income = _ledgerHandler.GetIncome(transactionsInMonth.Select(x => x.TotalValue).ToList());
            ledger.Expenses = _ledgerHandler.GetExpenses(employeesInMonth.ToList(), transactionsInMonth.ToList(), 5000);
            ledger.Total = ledger.Income - ledger.Expenses;
            
            return ledger;
        }
    }
}
