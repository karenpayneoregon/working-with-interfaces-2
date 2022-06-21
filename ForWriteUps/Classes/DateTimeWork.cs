using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForWriteUps.Classes
{
    public static class DateTimeWork
    {
        public static int GetAge(this DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var todayValue = (today.Year * 100 + today.Month) * 100 + today.Day;
            var birthValue = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;
            /*
             * Take todayValue - birthValue and drop last four digits
             */
            return (todayValue - birthValue) / 10000;
        }
    }
}
