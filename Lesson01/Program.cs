using System;
using Lesson01.Classes;
using Lesson01.Interfaces;
using Lesson01.LanguageExtensions;
using Lesson01.Models;
using Spectre.Console;

namespace Lesson01
{
    partial class Program
    {
        static void Main(string[] args)
        {

            //GetTaxpayersFromHelper();
            //GetPeopleFromHelper();
            //ExampleTwoInterfacesPatternMatching();
            //ExampleTwoInterfacesCasting();

            Console.ReadLine();
        }

        private static void GetTaxpayersFromHelper()
        {
            Console.WriteLine();
            AnsiConsole.MarkupLine($"[dodgerblue2 on white]{nameof(GetTaxpayersFromHelper).SplitCamelCase()}[/]");

            foreach (var person in Mocked.Taxpayers())
            {
                var (id, human) = Helpers.Item(person);
                Console.WriteLine($"{id,-3}{human.FirstName} {human.LastName}");
            }

            Console.WriteLine();

        }

        private static void GetPeopleFromHelper()
        {
            AnsiConsole.MarkupLine($"[yellow on red]{nameof(GetPeopleFromHelper).SplitCamelCase()}[/]");
            foreach (var person in Mocked.People())
            {
                var (id, human) = Helpers.Item(person);
                Console.WriteLine($"{id,-3}{human.FirstName} {human.LastName}");
            }

            Console.WriteLine();

        }

        private static void ExampleTwoInterfacesPatternMatching()
        {
            AnsiConsole.MarkupLine($"[teal on white]{nameof(ExampleTwoInterfacesPatternMatching).SplitCamelCase()}[/]");
            foreach (var person in Mocked.People())
            {
                if (person is IBase current and IHuman human)
                {
                    Console.WriteLine($"{current.Id,-3}{human.FirstName} {human.LastName}");
                }

            }

            Console.WriteLine();

        }

        private static void ExampleTwoInterfacesCasting()
        {
            AnsiConsole.MarkupLine($"[fuchsia on white]{nameof(ExampleTwoInterfacesCasting).SplitCamelCase()}[/]");
            foreach (var person in Mocked.People())
            {
                var id = ((IBase)person).Id;
                var human = (IHuman)person;
                Console.WriteLine($"{id,-3}{human.FirstName} {human.LastName}");
            }

            Console.WriteLine();
        }

        private static void ExampleTwoInterfacesCasting2()
        {
            AnsiConsole.MarkupLine($"[fuchsia on white]{nameof(ExampleTwoInterfacesCasting2).SplitCamelCase()}[/]");
            foreach (var person in Mocked.Taxpayers())
            {
                var id = ((IBase)person).Id;
                var human = (IHuman)person;
                Console.WriteLine($"{id,-3}{human.FirstName} {human.LastName}");
            }

            Console.WriteLine();
        }
    }
}
