using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ForWriteUps.Interfaces;

namespace ForWriteUps.Models
{
    public class Person : IHuman //, ICloneable
    {
        public int Id => PersonIdentifier;
        public int PersonIdentifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> List { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";

        //public object Clone()
        //{
        //    var json = JsonSerializer.Serialize(this);
        //    return JsonSerializer.Deserialize<Person>(json)!;
        //}

    }
}
