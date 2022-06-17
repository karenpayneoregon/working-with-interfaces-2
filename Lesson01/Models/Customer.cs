using Lesson01.Interfaces;

namespace Lesson01.Models
{
    interface IInterface
    {
        public int Id { get;  }
    }
    public class Customer : Human, IInterface
    {
        public int Id => HumanIdentifier;
        public override string ToString() => $"{FirstName}";
    }

    public class CustomersMocked
    {
        public static  Customer SomeCustomer => new ()
        {
            FirstName = "Jim",
            LastName = "Bob",
            HumanIdentifier = 0
        };
}
}
