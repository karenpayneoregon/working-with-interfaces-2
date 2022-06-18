using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatableExample.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public int CarId { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
