using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WithoutAsyncWpfApp.Models;

namespace WithoutAsyncWpfApp.ModelServices
{
    public static class CustomerService
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            var random = new Random();

            var names = new string[] 
            {
                "Rajesh", 
                "Mahesh", "Murugan", "Murthy",
                "Ismail", "Peter", "Isabella",
                "Natasha", "John", "George"
            };

            Thread.Sleep(5000);

            var customers = new List<Customer>(
                from index in Enumerable.Range(1, names.Length)
                select new Customer
                {
                    Id = index.ToString(),
                    Name = names[index - 1],
                    Address = "Bangalore",
                    CreditLimit = random.Next(20000, 50000),
                    ActiveStatus = index % 2 == 0
                });
            return customers;
        }
    }
}
