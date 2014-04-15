using GS.Libraries.ModelServices.Impl;
using GS.Libraries.ModelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Libraries.ModelServices.Factories
{
    public static class ServiceFactory
    {
        public static IService GetService(ServiceType serviceType)
        {
            var serviceObject = default(IService);

            switch (serviceType)
            {
                case ServiceType.Customers:
                    serviceObject = new CustomerService();
                    break;
                case ServiceType.Orders:
                    serviceObject = new OrderService();
                    break;
                default:
                    throw new ArgumentException("Invalid Service Type Specified!");
            }

            return serviceObject;
        }
    }
}
