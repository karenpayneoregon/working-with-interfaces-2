using Lesson02.Interfaces;

namespace Lesson02.Models
{
    public class Person : Human, IBase
    {
        public int PersonIdentifier { get; set; }
        public int Id => PersonIdentifier;
        public override string ToString()
        {
            return $"{Id,-4}{FirstName}{MiddleName}{LastName}";
        }
    }
}