namespace Lesson01.Interfaces
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";

    }
}