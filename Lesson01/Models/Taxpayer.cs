using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson01.Interfaces;

namespace Lesson01.Models
{
    public class Taxpayer : IBase, IHuman
    {
        public int TaxpayerIdentifier { get; set; }
        public int Id => TaxpayerIdentifier;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
