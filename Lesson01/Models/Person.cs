using Lesson01.Interfaces;

namespace Lesson01.Models
{
    public class Person : IBase, IHuman
    {
        public int PersonIdentifier { get; set; }
        public int Id => PersonIdentifier;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}