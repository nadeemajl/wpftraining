using GS.Libraries.Models;
using GS.Libraries.ModelServices.Factories;
using GS.Libraries.ModelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GS.Libraries.Commands
{
    public class LoadCustomersCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var customers = parameter as Customers;

            if (customers != default(Customers))
            {
                var customerService = ServiceFactory.GetService(
                    ServiceType.Customers) as ICustomerService;

                if (customerService != default(ICustomerService))
                {
                    var customersList = customerService.GetCustomers() as List<Customer>;

                    customers.Clear();

                    customersList.ForEach(
                        customer => customers.Add(customer));
                }
            }
        }
    }
}
