using System;
using ForWriteUps.Interfaces;

namespace ForWriteUps.Models
{
    public class Customer : IHuman
    {
        public int CustomerId { get; set; }
        public int Id => CustomerId;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}