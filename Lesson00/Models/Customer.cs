using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson00.Interfaces;

namespace Lesson00.Models
{
    public class Customer : IBaseEntity
    {
        public int CustomerIdentifier { get; set; }
        public string Name { get; set; }
        public int ContactIdentifier { get; set; }
        public int Id => CustomerIdentifier;
        
        public string DoSomething(string value)
        {
            return "Not default";
        }
    }

    public class Car : IBaseEntity
    {
        public int CarId { get; set; }
        public int Id => CarId;
        public string Name { get; set; }
    }

    public class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
