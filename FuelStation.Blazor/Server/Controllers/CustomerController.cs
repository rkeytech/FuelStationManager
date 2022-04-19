using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListViewModel>> Get()
        {
            var results = await _customerRepo.GetAllAsync();
            return results.Select(x => new CustomerListViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                CardNumber = x.CardNumber
            });
        }

        [HttpGet("{id}")]
        public async Task<CustomerEditViewModel> Get(uint id)
        {
            CustomerEditViewModel viewmodel = new CustomerEditViewModel();
            if (id != 0)
            {
                var foundCustomer = await _customerRepo.GetByIdAsync(id);
                viewmodel.ID = foundCustomer.ID;
                viewmodel.Name = foundCustomer.Name;
                viewmodel.Surname = foundCustomer.Surname;
                viewmodel.CardNumber = foundCustomer.CardNumber;
            }
            return viewmodel;
        }

        [HttpGet("card/{cardNumber}")]
        public async Task<CustomerEditViewModel> Get(string cardNumber)
        {
            CustomerEditViewModel viewmodel = new CustomerEditViewModel();
            if (!string.IsNullOrEmpty(cardNumber))
            {
                var foundCustomer = await _customerRepo.GetByAttrAsync(cardNumber);
                if (foundCustomer is not null)
                {
                    viewmodel.ID = foundCustomer.ID;
                    viewmodel.Name = foundCustomer.Name;
                    viewmodel.Surname = foundCustomer.Surname;
                    viewmodel.CardNumber = foundCustomer.CardNumber;
                }
            }
            return viewmodel;
        }

        [HttpPost]
        public async Task Post(CustomerEditViewModel customer)
        {
            var newCustomer = new Customer()
            {
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber
            };
            try
            {
                await _customerRepo.AddAsync(newCustomer);
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
                await _customerRepo.DeleteAsync(id);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditViewModel customer)
        {
            var customerToUpdate = await _customerRepo.GetByIdAsync(customer.ID);
            if (customerToUpdate == null) return NotFound();

            customerToUpdate.Name = customer.Name;
            customerToUpdate.Surname = customer.Surname;
            customerToUpdate.CardNumber = customer.CardNumber;
            try
            {
                await _customerRepo.UpdateAsync(customer.ID, customerToUpdate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
            return Ok();
        }

    }
}
