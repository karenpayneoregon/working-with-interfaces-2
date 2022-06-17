using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson00.Models
{
    interface IThing
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

    }

    public class Human : IThing
    {
        public int hId { get; set; }
        public int Id => hId;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class Alien : IThing
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasPointedEars { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class Dummy
    {
        public Dummy()
        {
            Human human = new Human() { BirthDate = DateTime.Now, FirstName = "", LastName = "", hId = 0 };
        }
    }
}
