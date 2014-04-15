using IOSupportInCmdWpfApp.Models;
using IOSupportInCmdWpfApp.ModelServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IOSupportInCmdWpfApp.Commands
{
    public class CustomerDetailsCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            var customerInfo = parameter as CustomerInfo;

            return customerInfo != default(CustomerInfo) &&
                !string.IsNullOrEmpty(customerInfo.ProfileId);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            var customerInfo = parameter as CustomerInfo;

            if (customerInfo != default(CustomerInfo))
            {
                var profileDetails = CustomerService.GetCustomerInfo(customerInfo.ProfileId);

                if (profileDetails != default(CustomerInfo))
                {
                    customerInfo.ProfileName = profileDetails.ProfileName;
                    customerInfo.Remarks = profileDetails.Remarks;
                }
            }
        }
    }
}
