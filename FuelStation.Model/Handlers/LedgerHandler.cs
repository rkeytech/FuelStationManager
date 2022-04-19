using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Handlers
{
    public class LedgerHandler
    {
        public LedgerHandler()
        {

        }

        public double GetIncome(List<double> transactions)
        {
            return Math.Round(transactions.Sum(), 2);
        }

        public double GetExpenses(List<Employee> employees, List<Transaction> transactions, double rent)
        { 
            double productsCosts = 0;
            double salaries = 0;

            foreach (var transaction in transactions)
            {
                productsCosts += transaction.TransactionLines.Select(x => x.Item.Cost).Sum();
            }

            salaries += employees.Select(x => x.SalaryPerMonth).Sum();

            return Math.Round(productsCosts + salaries + rent, 2);
        }
    }
}
