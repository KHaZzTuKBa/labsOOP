using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_2
{
    public abstract class DateTimeDecorator : IDateTimeFormatter
    {
        protected IDateTimeFormatter formatter;

        public DateTimeDecorator(IDateTimeFormatter formatter)
        {
            this.formatter = formatter;
        }

        public abstract string FormatDateTime();
    }

}