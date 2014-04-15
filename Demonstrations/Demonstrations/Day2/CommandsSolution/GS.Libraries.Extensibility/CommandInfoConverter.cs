using GS.Libraries.Shared;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace GS.Libraries.Extensibility
{
    public class CommandInfoConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var commandInfo = default(CommandInfo<object, object>);

            if (values != default(object[]))
            {
                commandInfo = new CommandInfo<object, object>
                {
                    Input = values[0],
                    Result = values[1]
                };
            }

            return commandInfo;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
