using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Libraries.Shared
{
    [Serializable]
    public class CommandInfo<TInput, TResult>
    {
        public TInput Input { get; set; }
        public TResult Result { get; set; }

        public override string ToString()
        {
            return string.Format(@"{0}, {1}",
                this.Input.ToString(), this.Result.ToString());
        }
    }
}
