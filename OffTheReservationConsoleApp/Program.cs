using System;
using OffTheReservationConsoleApp.Classes;
using Spectre.Console;

namespace OffTheReservationConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //AnsiConsole.WriteLine();
            //Render(new Rule($"[lightseagreen]Ambiguous[/]").RuleStyle(Style.Parse("yellow")).LeftAligned());

            //VehicleOperations.SerializeFirstAttempt();
            AnsiConsole.WriteLine();
            Render(new Rule($"[lightseagreen]Done right[/]").RuleStyle(Style.Parse("yellow")).LeftAligned());
            VehicleOperations.SerializeDoneRight();
            Console.ReadLine();
        }
    }
}
