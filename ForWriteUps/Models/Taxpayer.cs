using System;
using ForWriteUps.Interfaces;

namespace ForWriteUps.Models
{
    public class Taxpayer : IHuman
    {
        public int TaxpayerIdentifier { get; set; }
        public int Id => TaxpayerIdentifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}