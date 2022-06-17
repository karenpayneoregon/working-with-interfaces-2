using Lesson02.Interfaces;

namespace Lesson02.Models
{
    public class Employer : Human, IBase
    {
        public int EmployerIdentifier { get; set; }
        public int Id => EmployerIdentifier;
        public override string ToString()
        {
            return $"{LastName}";
        }
    }
}