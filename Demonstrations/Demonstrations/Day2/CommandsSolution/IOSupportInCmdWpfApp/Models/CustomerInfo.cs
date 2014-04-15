using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOSupportInCmdWpfApp.Models
{
    [Serializable]
    public class CustomerInfo : BaseModel
    {
        private string profileId;
        private string profileName;
        private string remarks;

        public string ProfileId
        {
            get { return profileId; }
            set { profileId = value; Notify(); }
        }

        public string ProfileName
        {
            get { return profileName; }
            set { profileName = value; Notify(); }
        }

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; Notify("Remarks"); }
        }

        public override string ToString()
        {
            return string.Format(@"{0}, {1}, {2}",
                this.profileId, this.profileName, this.remarks);
        }
    }
}
