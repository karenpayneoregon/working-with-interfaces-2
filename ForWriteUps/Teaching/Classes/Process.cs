using System;
using ForWriteUps.Teaching.Models;

namespace ForWriteUps.Teaching.Classes
{
    public static class Process
    {
        public static void Hillbilly(Person sender)
        {
            Console.WriteLine($"\t{nameof(Hillbilly)}, {sender.FirstName} {sender.LastName}");
        }
    }
}