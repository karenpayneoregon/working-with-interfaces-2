using System;
using System.Collections.Generic;
using Lesson00.Interfaces;
using Lesson00.LanguageExtensions;
using Lesson00.Models;
using Spectre.Console;

namespace Lesson00
{
    partial class Program
    {
        /// <summary>
        /// Here we created a list of <see cref="IBaseEntity"/>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            HowToIterateListImplementingInterface();

            HowToIterateWithInterfaceAndDistinguishCustomer();

            Console.ReadLine();
        }

        /// <summary>
        /// Consistency is the key here but how do we get Contact identifier, next example
        /// shows how.
        /// </summary>
        private static void HowToIterateListImplementingInterface()
        {
            AnsiConsole.MarkupLine($"[cyan]{nameof(HowToIterateListImplementingInterface).SplitCamelCase()}[/]");
            List<IBaseEntity> list = new()
            {
                new Customer() { CustomerIdentifier = 1, Name = "SomeCustomer", ContactIdentifier = 2 },
                new Car() { CarId = 1, Name = "Car 1" },
            };

            foreach (IBaseEntity entity in list)
            {
                Console.WriteLine($"{entity.Id,-4}{entity.Name}");
            }
        }

        /// <summary>
        /// Iterate list, test for type
        /// </summary>
        private static void HowToIterateWithInterfaceAndDistinguishCustomer()
        {

            AnsiConsole.MarkupLine($"[mediumspringgreen]{nameof(HowToIterateWithInterfaceAndDistinguishCustomer).SplitCamelCase()}[/]");

            List<IBaseEntity> list = new()
            {
                new Customer() { CustomerIdentifier = 1, Name = "SomeCustomer", ContactIdentifier = 2 },
                new Car() { CarId = 1, Name = "Car 1" },
            };

            foreach (IBaseEntity entity in list)
            {
                if (entity is Customer customer)
                {
                    Console.WriteLine($"{entity.Id,-4}{entity.Name,-20}{customer.ContactIdentifier}");
                }
                else
                {
                    Console.WriteLine($"{entity.Id,-4}{entity.Name}");
                }
            }
        }
    }
}
