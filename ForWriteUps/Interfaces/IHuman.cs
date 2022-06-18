using System;

namespace ForWriteUps.Interfaces
{
    public interface IHuman
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}