using System;
using Lesson02.Classes;
using Lesson02.Interfaces;
using Lesson02.LanguageExtensions;
using Lesson02.Models;
using Spectre.Console;

namespace Lesson02
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var foo = new Foo();
            Console.WriteLine(foo.ToString());

            GetTaxpayersFromHelper();
            InterfaceAbstractClassPatternMatching();
            GetPeopleFromHelper();
            InterfaceAbstractClassCasting();
            InterfaceAbstractClassCasting1();

            Console.ReadLine();
        }

        private static void GetTaxpayersFromHelper()
        {
            AnsiConsole.MarkupLine($"[yellow]{nameof(GetTaxpayersFromHelper).SplitCamelCase()}[/]");
            foreach (var person in Mocked.Taxpayers())
            {
                var (id, human) = Helpers.Item(person);
                Console.WriteLine($"{id,-3}{human}");
            }

            Console.WriteLine();

        }

        private static void GetPeopleFromHelper()
        {
            AnsiConsole.MarkupLine($"[fuchsia]{nameof(GetPeopleFromHelper).SplitCamelCase()}[/]");

            foreach (var person in Mocked.People())
            {
                var (id, human) = Helpers.Item(person);
                Console.WriteLine($"{id,-3}{human.FirstName} {human.LastName}");
            }

            Console.WriteLine();

        }

        private static void InterfaceAbstractClassPatternMatching()
        {
            AnsiConsole.MarkupLine($"[aqua]{nameof(InterfaceAbstractClassPatternMatching).SplitCamelCase()}[/]");
            foreach (var person in Mocked.People())
            {
                if (person is IBase current and Human human)
                {
                    Console.WriteLine($"{current.Id,-3}{human.FirstName} {human.LastName}");
                }

            }

            Console.WriteLine();

        }

        private static void InterfaceAbstractClassCasting()
        {
            AnsiConsole.MarkupLine($"[lime]{nameof(InterfaceAbstractClassCasting).SplitCamelCase()}[/] [yellow]{nameof(Person)}[/]");
            foreach (var person in Mocked.People())
            {
                var id = ((IBase)person).Id;
                var human = (Human)person;
                Console.WriteLine($"{id,-3}{human.FirstName} {human.LastName}");
            }

            Console.WriteLine();
        }

        private static void InterfaceAbstractClassCasting1()
        {
            AnsiConsole.MarkupLine($"[lime]{nameof(InterfaceAbstractClassCasting1).SplitCamelCase()}[/] [yellow]{nameof(Taxpayer)}[/]");
            foreach (var person in Mocked.Taxpayers())
            {
                var id = ((IBase)person).Id;
                var human = (Human)person;
                Console.WriteLine($"{id,-3}{human.FirstName} {human.LastName}");
            }

            Console.WriteLine();
        }
    }
}