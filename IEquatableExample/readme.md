# IEquatable&lt;T> Interface

*Defines a generalized method that a value type or class implements to create a type-specific method for determining equality of instances.*

In this example we are comparing first and last name case insensitive.

```csharp
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
```

Responsible for comparing two people case insensitive on first and last name

```csharp
public partial class Person : IEquatable<Person>
{
    public override bool Equals(object sender)
    {
        if (sender is not Person person)
        {
            return false;
        }

        return Id == person.Id &&
               string.Equals(FirstName, person.FirstName, StringComparison.OrdinalIgnoreCase) &&
               string.Equals(LastName, person.LastName, StringComparison.OrdinalIgnoreCase);

    }

    public bool Equals(Person person)
    {
        if (person == null)
        {
            return false;
        }

        return Id == person.Id && FirstName.AreEqual(person.FirstName) && LastName.AreEqual(person.LastName);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() ^ FirstName.GetHashCode() ^ LastName.GetHashCode();
    }

    public static bool operator ==(Person person1, Person person2)
    {
        if (ReferenceEquals(person1, person2))
        {
            return true;
        }

        if ((object)person1 == null || (object)person2 == null)
        {
            return false;
        }


        return person1.Id == person2.Id &&
               person1.FirstName.AreEqual(person2.FirstName) &&
               person1.LastName.AreEqual(person2.LastName);
    }

    public static bool operator !=(Person person1, Person person2)
    {
        return !(person1 == person2);
    }
}
```