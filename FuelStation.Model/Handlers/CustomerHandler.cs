using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Handlers
{
    public class CustomerHandler
    {
        public CustomerHandler()
        {

        }

        public Customer GetCustomerByCardNumber(List<Customer> customers, string cardNumber)
        {
            foreach (var customer in customers)
            {
                if(customer.CardNumber == cardNumber)
                    return customer;
            }
            return new Customer()
            {
                CardNumber = cardNumber
            };
        }
    }
}
