using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystemLibrary
{
    [Serializable]
    public class Customers : ObservableCollection<Customer>
    {
    }
}
