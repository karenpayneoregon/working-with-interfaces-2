using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatableExample.Extensions
{
    public static class Extension
    {
        /// <summary>
        /// Perform case insensitive equal on two strings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="item"></param>
        /// <returns>true if both strings are a match, false if not a match</returns>
        public static bool AreEqual(this string sender, string item) => string.Equals(sender, item, StringComparison.OrdinalIgnoreCase);
    }
}
