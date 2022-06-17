using System;
using System.Globalization;

namespace Playground.Classes
{
    public partial class SqlFormatProvider
    {
        public class SqlFormatter : ICustomFormatter
        {
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                if (arg == null)
                {
                    return "NULL";
                }

                // pattern matching
                if (arg is string stringValue)
                {
                    return $"'{stringValue.Replace("'", "''")}'";
                }

                if (arg is DateTime dateTime)
                {
                    return $"'{dateTime:MM/dd/yyyy}'";
                }

                if (arg is IFormattable formattable)
                {
                    return formattable.ToString(format, CultureInfo.InvariantCulture);
                }

                return arg.ToString();
            }
        }
    }
}