using System;
using ForWriteUps.Teaching.Interfaces;

namespace ForWriteUps.Teaching.Models
{
    public class Person : IHuman
    {
        public int PersonIdentifier { get; set; }
        public int Id => PersonIdentifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void Walk()
        {
            Console.WriteLine($"{FirstName} is walking");
        }

        public string Talk() => $"{FirstName} is talking";
        public string Talk(string says) => $"{says}";
        
        public Action<string> Action { get; set; }

    }
}
