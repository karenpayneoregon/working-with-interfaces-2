using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ForWriteUps.Teaching.Models;

namespace ForWriteUps.Teaching.Classes
{
    public class PersonOperations
    {

        [SuppressMessage("ReSharper", "All")]
        public static void ConvertToMethodGroup()
        {
            List<string> firstNames = new() { "Jed", "Granny", "Elly-May" };
 
            firstNames.ForEach(name => Console.WriteLine(name));
            firstNames.ForEach(Console.WriteLine);

            List<Person> hillbillies = new()
            {
                new() {FirstName = "Jed", LastName = "Clampett"},
                new() {FirstName = "Elly-May", LastName = "Clampett"},
                new() {FirstName = "Granny", LastName = "Clampett"},
            };

            hillbillies.ForEach(person => Process.Hillbilly(person));
            hillbillies.ForEach(Process.Hillbilly);

        }

        private static Person Person() => new()
        {
            PersonIdentifier = 10,
            FirstName = "Karen",
            LastName = "Payne",
            BirthDate = new DateTime(1956, 9, 24)
        };

        public static void CreatePerson()
        {
            Person person = Person();

            Console.WriteLine($"{person.PersonIdentifier,-4}{person.Id,-4}{person.FirstName} {person.LastName}");
        }

        public static void CreateAndWalk()
        {
            Person person = Person();

            person.Walk();

        }

        public static void CreateAndTalk()
        {
            Person person = Person();

            Console.WriteLine(person.Talk());

        }

        public static void WalkingAndTalking()
        {
            Person person = Person();
            Console.WriteLine(person.Talk($"{person.FirstName} is walking, talking and chewing gum"));
        }
        public static void Action()
        {
            Person person = Person();
            person.FirstName = "Bob";
            person.Action = Console.WriteLine;
            person.Action($"{person.FirstName}, time of day is {DateTime.Now:t}");
        }
    }
}