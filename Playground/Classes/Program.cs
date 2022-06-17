using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Spectre.Console;
using Color = System.Drawing.Color;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace Playground
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = $"Code sample: {Assembly.GetCallingAssembly().GetName().Name} - playground";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }

        private static List<DateTime> DateTimes => new()
        {
            new DateTime(1970, 1, 1),
            new DateTime(1980, 1, 1),
            new DateTime(1990, 1, 1),
            new DateTime(2000, 1, 1),
            new DateTime(2010, 1, 1),
        };

        /// <summary>
        /// Sometimes we must deal with object as in the case below expecting type object
        /// as a parameter, for example with IValueConverter Interface so that we can
        /// write converters from one type to another in WPF data binding.
        ///
        /// Similarly with the method Item in Lesson02 Helpers class
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static object ColorForDecade(object value) =>
            (((DateTime)value).Year / 10 * 10) switch
            {
                1970 => Color.Maroon,
                1980 => Color.DarkGreen,
                1990 => Color.DarkSlateBlue,
                2000 => Color.CadetBlue,
                _ => Color.DarkSlateGray,
            };

        private static Table CreateViewTable() =>
            new Table()
                .Border(TableBorder.Square)
                .BorderColor(Spectre.Console.Color.Grey)
                .Alignment(Justify.Center)
                .Title("[cyan][B]Results[/][/]")
                .AddColumn(new TableColumn("Decade"))
                .AddColumn(new TableColumn("Color"));
    }
}





