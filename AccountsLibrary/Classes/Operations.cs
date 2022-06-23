using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsLibrary.Models;

namespace AccountsLibrary.Classes
{
    public class Operations : MustInitialize<decimal>
    {
        public Operations(decimal parameter) : base(parameter)
        {
        }
    }

    public class TestOperations
    {
        public static void Example1()
        {
            Operations operations = new(1m);
            
        }
    }
}
