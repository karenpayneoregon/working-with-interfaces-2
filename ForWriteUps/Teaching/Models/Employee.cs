using System;
using ForWriteUps.Teaching.Interfaces;

namespace ForWriteUps.Teaching.Models
{
    class Employee : IHuman
    {
        public int EmployeeIdentifier { get; set; }

        public int Id => EmployeeIdentifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void Walk()
        {
            Console.WriteLine("Manager walking");
        }

        public string Talk() => "Manager talking";
        public string Talk(string say) => $"{LastName} says {say}";

        public Action<string> Action { get; set; }

    }
}