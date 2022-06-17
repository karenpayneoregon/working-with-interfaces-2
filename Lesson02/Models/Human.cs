namespace Lesson02.Models
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public abstract override string ToString(); // => $"{FirstName} {LastName}";

    }
}