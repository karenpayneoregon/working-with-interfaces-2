using System;
using System.Collections.Generic;
using ForWriteUps.Interfaces;
using ForWriteUps.Models;

namespace ForWriteUps.Classes
{
    public class Mocking
    {
        public static List<IHuman> List() => new ()
        {
            new Customer() { CustomerId = 1, BirthDate = new DateTime(1999, 12, 3), FirstName = "Bill", LastName = "Jones" },
            new Employee() { EmployeeId = 2, BirthDate = new DateTime(2001, 1, 4), FirstName = "Mary", LastName = "Gallagher" },
            new Employee() {EmployeeId = 4, BirthDate = new DateTime(1980,9,1), FirstName = "Jim", LastName = "Adams"}
        };
    }
}