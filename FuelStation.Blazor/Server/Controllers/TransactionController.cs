using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Model.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    //TODO: Create the transaction controller to work properly
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly TransactionHandler _transactionHandler;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, TransactionHandler transactionHandler)
        {
            _transactionRepo = transactionRepo;
            _transactionHandler = transactionHandler;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListViewModel>> Get()
        {
            var results = await _transactionRepo.GetAllAsync();
            return results.Select(x => new TransactionListViewModel
            {
                ID = x.ID,
                Date = x.Date,
                Employee = $"{x.Employee?.Surname} {x.Employee?.Name}",
                Customer = $"{x.Customer?.Surname} {x.Customer?.Name}",
                PaymentMethod = x.PaymentMethod.ToString(),
                TotalValue = x.TotalValue
            });
        }

        [HttpGet("{id}")]
        public async Task<TransactionEditViewModel> Get(uint id)
        {
            TransactionEditViewModel viewmodel = new TransactionEditViewModel();
            if (id != 0)
            {
                var foundTransaction = await _transactionRepo.GetByIdAsync(id);
                viewmodel.ID = foundTransaction.ID;
                viewmodel.Date = foundTransaction.Date;
                viewmodel.CustomerID = foundTransaction.CustomerID;
                viewmodel.EmployeeID = foundTransaction.EmployeeID;
                viewmodel.PaymentMethod = foundTransaction.PaymentMethod;
                viewmodel.TotalValue = foundTransaction.TotalValue;
                viewmodel.TransactionLines = foundTransaction.TransactionLines.Select(x => new TransactionLineViewModel
                {
                    ID = x.ID,
                    ItemID = x.ItemID,
                    ItemName = x.Item.Description,
                    Quantity = x.Quantity,
                    ItemPrice = x.Item.Price,
                    ItemType = x.Item.ItemType,
                    NetValue = x.NetValue,
                    DiscountPercent = x.DiscountPercent,
                    DiscountValue = x.DiscountPercent,
                    TotalValue = x.TotalValue
                }).ToList();
            }
            return viewmodel;
        }

        [HttpPost]
        public async Task Post(TransactionEditViewModel transaction)
        {
            var newTransaction = new Transaction()
            {
                EmployeeID = transaction.EmployeeID,
                CustomerID = transaction.CustomerID,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TotalValue,
                TransactionLines = transaction.TransactionLines.Select(x => new TransactionLine
                {
                    ItemID = x.ItemID,
                    Quantity = x.Quantity,
                    ItemPrice = x.ItemPrice,
                    NetValue = x.NetValue,
                    DiscountPercent = x.DiscountPercent,
                    DiscountValue = x.DiscountValue,
                    TotalValue = x.TotalValue
                }).ToList()
            };
            try
            {
                await _transactionRepo.AddAsync(newTransaction);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
        }

        [HttpDelete("{id}")]
        public async Task Delete(uint id)
        {
            try
            {
                await _transactionRepo.DeleteAsync(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
        }

        //[HttpPut]
        //public async Task<ActionResult> Put(ItemEditViewModel item)
        //{
        //    var itemToUpdate = await _transactionRepo.GetByIdAsync(item.ID);
        //    if (itemToUpdate == null) return NotFound();

        //    itemToUpdate.Code = item.Code;
        //    itemToUpdate.Description = item.Description;
        //    itemToUpdate.Cost = item.Cost;
        //    itemToUpdate.Price = item.Price;
        //    itemToUpdate.ItemType = item.ItemType;

        //    await _transactionRepo.UpdateAsync(item.ID, itemToUpdate);
        //    return Ok();
        //}

    }
}
