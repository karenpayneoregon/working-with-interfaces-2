using System;
using IEquatableExample.Classes;
using Spectre.Console;

namespace IEquatableExample
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var people = Mock.TwoPersons;

            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine($"  [deepskyblue1]people[[0]][/] [white] equal[/] [deepskyblue1]people[[1]][/] [cyan]?[/] [deepskyblue1]{people[0] == people[1]}[/]");

            Console.ReadLine();
        }
    }
}
