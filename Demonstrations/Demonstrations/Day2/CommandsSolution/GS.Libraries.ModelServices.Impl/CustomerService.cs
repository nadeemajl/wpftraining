using GS.Libraries.Models;
using GS.Libraries.ModelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Libraries.ModelServices.Impl
{
    public class CustomerService : ICustomerService
    {
        public IEnumerable<Customer> GetCustomers()
        {
            var random = new Random();

            var names = new string[] 
            {
                "Rajesh", 
                "Mahesh", "Murugan", "Murthy",
                "Ismail", "Peter", "Isabella",
                "Natasha", "John", "George"
            };

            var photosFolder = ConfigurationManager.AppSettings["PhotosFolder"];

            var customers = new List<Customer>(
                from index in Enumerable.Range(1, names.Length)
                select new Customer
                {
                    Id = index.ToString(),
                    Name = names[index - 1],
                    Address = "Bangalore",
                    CreditLimit = random.Next(20000, 50000),
                    ActiveStatus = index % 2 == 0,
                    PhotoUrl = string.Format(@"{0}\Customer Photo ({1}).jpg",
                        photosFolder, index.ToString())
                });

            return customers;
        }
    }
}
