using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using ClearPictureOfInterface.Interfaces;
using Spectre.Console;

namespace ClearPictureOfInterface.Models
{
    public class Waiter
    {
        public void TakeOrder(IEnumerable<MenuItem> order)
        {

            // Cook first (all except soda because soda is not IFood)
            AnsiConsole.MarkupLine("[red]Cooking[/] [yellow]food[/]");
            foreach (var food in order.OfType<IFood>())
            {
                food.Cook();
            }

            AnsiConsole.Status()
                .Start("[cyan]Preparing...[/]", ctx =>
                {
                    ctx.Spinner(Spinner.Known.Star);
                    ctx.SpinnerStyle(Style.Parse("yellow"));

                    AnsiConsole.MarkupLine("[red]cooking...[/]");
                    Thread.Sleep(2000);
                });

            // Bring all to the table (everything, including soda, pizza and burger because they're all menu items)
            AnsiConsole.MarkupLine("[pink1]Serving[/]");
            foreach (MenuItem menuItem in order)
            {
                menuItem.BringToTable();
            }
        }
    }
}