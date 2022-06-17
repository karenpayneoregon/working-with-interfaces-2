using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson02.Interfaces;

namespace Lesson02.Models
{
    public class Foo : IFoo
    {
        public string ToString(string format, IFormatProvider formatProvider) =>
            "IFormattable.ToString";
    }
}
