using System;
using System.Collections.Generic;
using ForWriteUps.Extensions;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Force.DeepCloner;
using ForWriteUps.Interfaces;
using ForWriteUps.Models;

namespace ForWriteUps.Classes
{
    public class WorkOperations
    {
        public static void IterateHumans()
        {
            var humans = Mocking.List();
            foreach (var human in humans)
            {
                Console.WriteLine($"{human.GetType().Name,-12} {human.Id,-3}{human.FirstName,-12}{human.LastName,-12}{human.BirthDate:d}");
            }
        }

        public static void ComparerBuilderExample()
        {
            var builder = new ComparerBuilder<IHuman>();
            var comparer = builder
                .SortKey(human => human.LastName)
                .ThenKeyDescending(human => human.BirthDate)
                .Build();

            var list = Mocking.List();
            list.Sort(comparer);
            
        }
        public static void NotNullExample()
        {
            List<int?> list = new () { 1, null, 3, 4, 5 };

            var results = list.WhereNotNull();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            var values = new[] {"1", null,"3"}.WhereNotNull();

            foreach (var month in values)
            {
                Console.WriteLine($"'{month}'");
            }

        }

        /// <summary>
        /// https://github.com/force-net/DeepCloner
        /// https://stackoverflow.com/a/56933017/5509738
        /// </summary>
        public static void CloneWithDeepCloner()
        {
            Person person = new ()
            {
                PersonIdentifier = 1, 
                FirstName = "Karen", 
                LastName = "Payne", 
                BirthDate = new DateTime(1956,9,24)
            };


            Person deepCloned = person.DeepClone();

            Console.WriteLine($"person == deepCloned? {person == deepCloned}");

            person.PersonIdentifier = 2;
            person.BirthDate = DateTime.Now;
            deepCloned.FirstName = "Jane";

            person.IterateClassProperties();
            Console.WriteLine();
            deepCloned.IterateClassProperties();

        }


    }
}