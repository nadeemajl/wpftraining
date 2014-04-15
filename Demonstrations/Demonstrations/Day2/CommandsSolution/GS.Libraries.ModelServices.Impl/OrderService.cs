using GS.Libraries.Models;
using GS.Libraries.ModelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Libraries.ModelServices.Impl
{
    public class OrderService : IOrderService
    {
        public IEnumerable<Order> GetOrders(string customerId)
        {
            var random = new Random();

            var ordersList = new List<Order>(
                from index in Enumerable.Range(1, random.Next(10, 15))
                select new Order
                {
                    OrderId = index.ToString(),
                    OrderDate = DateTime.Now.AddDays(-random.Next(30)),
                    CustomerId = customerId,
                    NoOfUnits = random.Next(20, 50),
                    Amount = random.Next(100, 1000)
                });

            return ordersList;
        }
    }
}
