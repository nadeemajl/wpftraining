using GS.Libraries.Models;
using GS.Libraries.ModelServices.Factories;
using GS.Libraries.ModelServices.Interfaces;
using GS.Libraries.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GS.Libraries.Commands
{
    public class LoadOrdersCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var commandInfo = parameter as CommandInfo<object, object>;
            var selectedCustomer = commandInfo.Input as Customer;
            var orders = commandInfo.Result as Orders;

            if (selectedCustomer != default(Customer) && orders != default(Orders))
            {
                var orderService = ServiceFactory.GetService(
                    ServiceType.Orders) as IOrderService;

                if (orderService != default(IOrderService))
                {
                    var ordersList = orderService.GetOrders(selectedCustomer.Id) as List<Order>;

                    orders.Clear();

                    ordersList.ForEach(
                        order => orders.Add(order));
                }
            }
        }
    }
}
