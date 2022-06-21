using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ForWriteUps.Extensions
{
    public static class Extensions
    {

        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T> sequence)
            => sequence.Where(item => item is not null);

        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> sequence) where T : struct
            => sequence.Where(item => item is not null).Select(e => e.Value);

        /// <summary>
        /// Use to split on upper cased characters and separate with a single space.
        /// </summary>
        public static string SplitCamelCase(this string sender) =>
            string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
                .Select(m => m.Value));

        public static string FirstPart(this string sender)
        {
            var parts = sender.SplitCamelCase().Split(' ');
            return parts.Length > -1 ? parts[0] : sender;
        }

        public static string RemoveSystem(this string sender) => sender.Replace("System.", "");



    }
}

