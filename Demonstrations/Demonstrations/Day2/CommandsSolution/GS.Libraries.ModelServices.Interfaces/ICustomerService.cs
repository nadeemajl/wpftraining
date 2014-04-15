using GS.Libraries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Libraries.ModelServices.Interfaces
{
    public interface ICustomerService : IService
    {
        IEnumerable<Customer> GetCustomers();
    }
}
