using System;

namespace ForWriteUps.Teaching.Interfaces
{
    interface IHuman
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public void Walk();
        public string Talk();
        public string Talk(string say);
        Action<string> Action { get; set; }
    }
}