using IOSupportInCmdWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOSupportInCmdWpfApp.ModelServices
{
    public static class CustomerService
    {
        public static CustomerInfo GetCustomerInfo(string customerId)
        {
            var random = new Random();

            var names = new string[] 
            {
                "Rajesh", 
                "Mahesh", "Murugan", "Murthy",
                "Ismail", "Peter", "Isabella",
                "Natasha", "John", "George"
            };

            var customers = new List<CustomerInfo>(
                from index in Enumerable.Range(1, names.Length)
                select new CustomerInfo
                {
                    ProfileId = index.ToString(),
                    ProfileName = names[index - 1],
                    Remarks = "Simple Customer Record"
                });

            var filteredCustomer = customers.Where(
                customer => customer.ProfileId.Equals(customerId)).FirstOrDefault();

            return filteredCustomer;
        }
    }
}
