using System;

namespace ForWriteUps.Interfaces
{
    public class Manager : IHuman
    {
        public int ManagerIdentifier { get; set; }
        public int Id => ManagerIdentifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

    }
}