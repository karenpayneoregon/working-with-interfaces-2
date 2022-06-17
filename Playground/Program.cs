using System;
using System.Collections.Generic;
using Playground.Classes;
using Playground.LanguageExtensions;
using Playground.Models;
using Spectre.Console;
using Color = System.Drawing.Color;

namespace Playground
{
    partial class Program
    {
        static void Main(string[] args)
        {
            FormatExample();
            TimesForUsingObjectType();

            Console.ReadLine();
        }

        private static void FormatExample()
        {
            AnsiConsole.MarkupLine($"[yellow]{nameof(FormatExample).SplitCamelCase()}[/]");
            Console.CursorTop = 2;
            var result = FormattableSqlStatement();
            result = result
                .Replace("'", "[hotpink]'[/]")
                .Replace("INSERT INTO", "[deepskyblue1]INSERT INTO[/]")
                .Replace("VALUES", "[deepskyblue1]VALUES[/]");

            AnsiConsole.MarkupLine(result);
        }

        private static string FormattableSqlStatement()
        {

            //  local method
            static string Sql(FormattableString formattable)
            {
                return formattable.ToString(new SqlFormatProvider());
            }

            Person person = new() { Id = 12, FirstName = "Karen", LastName = "Payne" };

            
            string sql = Sql($"INSERT INTO People(id, FirstName, LastName, BirthDate) VALUES({person.Id}, {person.FirstName}, {person.LastName}, {new DateTime(1960, 12, 1)})");
            return sql;
        }

        private static void TimesForUsingObjectType()
        {

            Console.CursorTop = 5;
            AnsiConsole.MarkupLine($"[cyan]{nameof(TimesForUsingObjectType).SplitCamelCase()}[/]");
            Console.CursorVisible = false;

            var table = CreateViewTable();

            foreach (var dateTime in DateTimes)
            {
                table.AddRow($"{dateTime,-12:d}", ((Color)ColorForDecade(dateTime)).Name);
            }

            AnsiConsole.Write(table);

            AnsiConsole.MarkupLine("[springgreen1]Press any key to close[/]");
        }
    }
}
