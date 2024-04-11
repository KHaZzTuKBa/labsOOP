using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_2
{
    public class SymbolDateTimeDecorator : DateTimeDecorator
    {
        private string symbol;

        public SymbolDateTimeDecorator(IDateTimeFormatter formatter, string symbol) : base(formatter)
        {
            this.symbol = symbol;
        }

        public override string FormatDateTime()
        {
            var dateStr = formatter.FormatDateTime();
            var sb = new StringBuilder(dateStr);
            sb.Insert(0, symbol);
            sb.Append(symbol);
            return sb.ToString();
        }
    }
}
