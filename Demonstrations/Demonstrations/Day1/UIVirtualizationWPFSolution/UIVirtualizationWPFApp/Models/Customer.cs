using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UIVirtualizationWPFApp.Models
{
    [Serializable]
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CreditLimit { get; set; }
        public bool ActiveStatus { get; set; }

        public override string ToString()
        {
            return string.Format(@"{0}, {1}, {2}, {3}, {4}",
                this.Id, this.Name, this.Address, this.CreditLimit, this.ActiveStatus);
        }
    }
}
