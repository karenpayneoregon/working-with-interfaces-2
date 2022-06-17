using Lesson02.Interfaces;

namespace Lesson02.Models
{
    public class Taxpayer : Human, IBase
    {
        public int TaxpayerIdentifier { get; set; }
        public int Id => TaxpayerIdentifier;

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
