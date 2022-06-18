using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEquatableExample.Models;

namespace IEquatableExample.Classes
{
    class Mock
    {
        public static List<Person> TwoPersons =>
            new()
            {
                new() { FirstName = "Karen", LastName = "Payne" },
                new() { FirstName = "Karen", LastName = "Payne" }
            };

        public static List<Person> FourPersons =>
            new()
            {
                new() { FirstName = "Karen", LastName = "Payne" },
                new() { FirstName = "karen", LastName = "payne" },
                new() { FirstName = "Karen", LastName = "Adams" },
                new() { FirstName = "Karen", LastName = "Payne" }
            };
    }
}
