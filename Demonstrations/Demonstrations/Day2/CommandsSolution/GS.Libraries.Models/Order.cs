using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Libraries.Models
{
    [Serializable]
public     class Order 
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerId { get; set; }
        public int NoOfUnits { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return string.Format(@"{0}, {1}, {2}, {3}, {4}",
                this.OrderId, this.OrderDate.ToString(),
                this.CustomerId, this.NoOfUnits, this.Amount);
        }
    }
}
