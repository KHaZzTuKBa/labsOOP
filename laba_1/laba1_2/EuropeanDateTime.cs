using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_2
{
    public class EuropeanDateTime : IDateTimeFormatter
    {
        public string FormatDateTime()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("ru-RU");
            return DateTime.Now.ToString(culture);
        }
    }
}
