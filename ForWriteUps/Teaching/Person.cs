using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForWriteUps.Teaching
{

    interface IHuman
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public void Walk();
        public string Talk();
        Action<string> YourAction { get; set; }
    }

    class Person : IHuman
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

        public Action<string> YourAction { get; set; }

    }

    public class PersonOperations
    {
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

            Console.WriteLine($"{person.PersonIdentifier,-4}{person.FirstName} {person.LastName}");
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
        public static void Action()
        {
            Person person = Person();
            person.FirstName = "Bob";
            person.YourAction = Console.WriteLine;

            person.YourAction($"{person.FirstName}, time of day is {DateTime.Now:t}");
        }
    }

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

        public Action<string> YourAction { get; set; }

    }
}
