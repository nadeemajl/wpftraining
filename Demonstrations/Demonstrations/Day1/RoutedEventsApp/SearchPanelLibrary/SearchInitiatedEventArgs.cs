using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SearchPanelLibrary
{
    public class SearchInitiatedEventArgs : RoutedEventArgs
    {
        public SearchInitiatedEventArgs(RoutedEvent routedEvent) : base(routedEvent) { }

        public string UserName { get; set; }
        public string SearchString { get; set; }
        public DateTime InitiatedTime { get; set; }
        public override string ToString()
        {
            return string.Format(@"{0}, {1}, {2}",
                this.InitiatedTime.ToString(), this.UserName, this.SearchString);
        }
    }
}
