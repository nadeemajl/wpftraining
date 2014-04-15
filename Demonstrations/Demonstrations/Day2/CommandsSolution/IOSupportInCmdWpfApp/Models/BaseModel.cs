using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IOSupportInCmdWpfApp.Models
{
    [Serializable]
    public abstract class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void Notify(
            [CallerMemberName] string propertyName = default(string))
        {
            if (!string.IsNullOrEmpty(propertyName) &&
                PropertyChanged != default(PropertyChangedEventHandler))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
