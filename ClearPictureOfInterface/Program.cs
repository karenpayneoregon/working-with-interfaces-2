using System;
using System.Collections.Generic;
using ClearPictureOfInterface.Models;
using Spectre.Console;

namespace ClearPictureOfInterface
{
    partial class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine("[white]Taking order[/]");
            Waiter waiter = new ();
            List<MenuItem> menuItems = new List<MenuItem>()
            {
                new Burger(), new Pizza(), new Soda()
            };
            
            waiter.TakeOrder(menuItems);

            Console.ReadLine();
        }
    }
}
