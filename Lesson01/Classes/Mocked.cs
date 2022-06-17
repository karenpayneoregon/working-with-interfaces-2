using System;
using System.Collections.Generic;
using Lesson01.Models;

namespace Lesson01.Classes
{

    public class Mocked
    {

        public static List<Person> People() =>
            new ()
            {
                new () {PersonIdentifier = 1, FirstName = "Karen", MiddleName = "", LastName = "Payne"},
                new () {PersonIdentifier = 2, FirstName = "Jim", MiddleName = "A", LastName = "Smith"},
            };
        public static List<Taxpayer> Taxpayers() =>
            new()
            {
                new() { TaxpayerIdentifier = 1, FirstName = "Karen", MiddleName = "", LastName = "Payne" },
                new() { TaxpayerIdentifier = 2, FirstName = "Jim", MiddleName = "A", LastName = "Smith" },
            };
    }
}