using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIVirtualizationWPFApp.Models;

namespace UIVirtualizationWPFApp.ModelServices
{
    public static class CustomerService
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            var random = new Random();

            var customers = new List<Customer>(
                from index in Enumerable.Range(1, 1000000)
                select new Customer
                {
                    Id = index.ToString(),
                    Name = Guid.NewGuid().ToString(),
                    Address = "Bangalore",
                    CreditLimit = random.Next(20000, 50000),
                    ActiveStatus = index % 2 == 0
                });
            return customers;
        }
    }
}
