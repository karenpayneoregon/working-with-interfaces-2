using System;
using ForWriteUps.Interfaces;

namespace ForWriteUps.Models
{
    public class Employee : IHuman
    {
        public int EmployeeId { get; set; }
        public int Id => EmployeeId;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}