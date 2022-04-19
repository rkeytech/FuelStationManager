using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListViewModel>> Get()
        {
            var results = await _employeeRepo.GetAllAsync();
            return results.Select(x => new EmployeeListViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                SalaryPerMonth = x.SalaryPerMonth,
                HireDateStart = x.HireDateStart,
                HireDateEnd = x.HireDateEnd,
                EmployeeType = x.EmployeeType.ToString()
            });
        }

        [HttpGet("{id}")]
        public async Task<EmployeeEditViewModel> Get(uint id)
        {
            EmployeeEditViewModel viewmodel = new EmployeeEditViewModel()
            {
                HireDateStart = DateTime.Now,
            };
            if (id != 0)
            {
                var foundEmployee = await _employeeRepo.GetByIdAsync(id);
                viewmodel.ID = foundEmployee.ID;
                viewmodel.Name = foundEmployee.Name;
                viewmodel.Surname = foundEmployee.Surname;
                viewmodel.SalaryPerMonth = foundEmployee.SalaryPerMonth;
                viewmodel.HireDateStart = foundEmployee.HireDateStart;
                viewmodel.HireDateEnd = foundEmployee.HireDateEnd;
                viewmodel.EmployeeType = foundEmployee.EmployeeType;
            }
            return viewmodel;
        }

        [HttpPost]
        public async Task Post(EmployeeEditViewModel employee)
        {
            var newEmployee = new Employee()
            {
                Name = employee.Name,
                Surname = employee.Surname,
                SalaryPerMonth = employee.SalaryPerMonth,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                EmployeeType = employee.EmployeeType
            };
            try
            {
                await _employeeRepo.AddAsync(newEmployee);
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
                await _employeeRepo.DeleteAsync(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeEditViewModel employee)
        {
            var employeeToUpdate = await _employeeRepo.GetByIdAsync(employee.ID);
            if (employeeToUpdate == null) return NotFound();

            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.Surname = employee.Surname;
            employeeToUpdate.SalaryPerMonth = employee.SalaryPerMonth;
            employeeToUpdate.HireDateStart = employee.HireDateStart;
            employeeToUpdate.HireDateEnd = employee.HireDateEnd;
            employeeToUpdate.EmployeeType = employee.EmployeeType;

            try
            {
                await _employeeRepo.UpdateAsync(employee.ID, employeeToUpdate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
            return Ok();
        }

    }
}
