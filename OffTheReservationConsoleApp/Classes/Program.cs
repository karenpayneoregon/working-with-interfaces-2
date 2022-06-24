using System;
using System.Runtime.CompilerServices;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace OffTheReservationConsoleApp
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
        private static void Render(Rule rule)
        {
            AnsiConsole.Write(rule);
            AnsiConsole.WriteLine();
        }
    }
}





