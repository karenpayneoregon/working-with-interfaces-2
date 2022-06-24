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
            Console.WriteLine($"{FirstName} walking");
        }

        public string Talk() => $"{FirstName} talking";
        public string Talk(string says) => $"{says}";
        
        public Action<string> Action { get; set; }

    }

    public static class Process
    {
        public static void Hillbilly(Person sender)
        {
            Console.WriteLine($"\t{nameof(Hillbilly)}, {sender.FirstName} {sender.LastName}");
        }
    }
}
