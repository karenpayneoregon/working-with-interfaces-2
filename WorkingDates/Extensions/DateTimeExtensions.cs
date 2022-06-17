using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDates.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime Next(this DateTime from, DayOfWeek dayOfTheWeek)
        {
            var date = from.Date.AddDays(1);
            var days = ((int)dayOfTheWeek - (int)date.DayOfWeek + 7) % 7;
            return date.AddDays(days);
        }

        public static IReadOnlyList<DateTime> Next(
            this DateTime from,
            params DayOfWeek[] days
        )
        {
            return Next(from, DateCalculationKind.And, days);
        }

        public static IReadOnlyList<DateTime> Next(
            this DateTime from,
            DateCalculationKind calculationKind,
            params DayOfWeek[] days
        )
        {
            if (days == null)
                return new DateTime[0];

            var results = new List<DateTime>();

            // And means, we don't want to duplicate data
            days = calculationKind == DateCalculationKind.And
                ? days.Distinct().ToArray()
                : days;

            DateTime? result = null;
            foreach (var dayOfWeek in days)
            {
                result = calculationKind == DateCalculationKind.And || result is null
                    ? Next(from, dayOfWeek)
                    : Next(result.Value, dayOfWeek);

                results.Add(result.Value);
            }

            return results;
        }
    }
}
