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

   
    public class Car : IBaseEntity
    {
        public int CarId { get; set; }
        public int Id => CarId;
        public string Name { get; set; }
    }
    
}
