using System;
using Lesson00.Interfaces;
namespace Lesson00.Models
{
    public class Customer : IBaseEntity
    {
        public int CustomerIdentifier { get; set; }
        public int Id => CustomerIdentifier;
        public string Name { get; set; }
        public int ContactIdentifier { get; set; }
        public string DoSomething(string value)
        {
            return "Not default";
        }
    }

    interface IInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }

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
