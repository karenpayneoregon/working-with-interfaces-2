using System;

namespace Playground.Classes
{
    public partial class SqlFormatProvider : IFormatProvider
    {
        private readonly SqlFormatter _formatter = new();

        public object GetFormat(Type formatType)
        {
            return formatType == typeof(ICustomFormatter) ? _formatter : null;
        }
    }
}