# Classes

In plain English

Everything in C# is associated with classes and objects, 
along with its attributes and methods. 
For example: in real life, a `person` is an object. 
The `person` has attributes/properties, such as first/last name and birthdate, and methods, such as walk and speak.

A Person class 

```csharp
class Person
{
    public int PersonIdentifier { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}
```

Suppose we now want an Employee class

```csharp
class Employee
{
    public int EmployeeIdentifier { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}
```

Well, Person and Employee share the same properties which is where interfaces come into play.

Here we have identified common properties which are placed into the following interface.

As explain in the last class we allow the primary key to be different and to know the primary key, in the interface define a read-only property `Id` which points to the real primary key.

```csharp
interface IHuman
{
    public int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}

class Person : IHuman
{
    public int PersonIdentifier { get; set; }
    public int Id => PersonIdentifier;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}

class Employee : IHuman
{
    public int EmployeeIdentifier { get; set; }

    public int Id => EmployeeIdentifier;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}
```

**Adding events**

```csharp
interface IHuman
{
    public int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public void Walk();
    public string Talk();
}
```

**Implement events**

```csharp
class Person : IHuman
{
    public int PersonIdentifier { get; set; }
    public int Id => PersonIdentifier;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public void Walk()
    {
        Console.WriteLine("Person walking");
    }

    public string Talk() => "Person talking";
}

class Employee : IHuman
{
    public int EmployeeIdentifier { get; set; }

    public int Id => EmployeeIdentifier;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public void Walk()
    {
        Console.WriteLine("Manager walking");
    }
    public string Talk() => "Manager talking";
}
```

**Caveat**

The above classes are better known as models which are containers which represent something e.g. a person and employee.

**Implementing Actions**

`Action` Encapsulates a method that has a single parameter and does not return a value.

```csharp
interface IHuman
{
    public int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public void Walk();
    public string Talk();
    Action<string> Action { get; set; }
}
```

**Example** (yes I pick a really good name for Action)

```csharp
class Person : IHuman
{
    public int PersonIdentifier { get; set; }
    public int Id => PersonIdentifier;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public void Walk()
    {
        Console.WriteLine($"{FirstName} walking");
    }

    public string Talk() => $"{FirstName} talking";

    public Action<string> Action { get; set; }

}
```

Let's invoke the Action

```csharp
public static void Action()
{
    Person person = Person();
    person.FirstName = "Bob";
    person.Action = Console.WriteLine;
    person.Action($"{person.FirstName}, time of day is {DateTime.Now:t}");
}
```
In the above, Console.WriteLine is a `method group`.

**Method Group**: It is a compiler term for "I know what the method name is, but I don't know the signature"; it has no existence at runtime, where it is converted in the correct overload.

Below both `ForEach` display each name in a Console app

```csharp
private static void ConvertToMethodGroup()
{
    List<string> names = new List<string>() {"Karen", "Bick", "James", "Garen", "Lindon"};

    names.ForEach(name => Console.WriteLine(name));
    names.ForEach(Console.WriteLine);

}
```

For those old enough, here is something relatable

```csharp
private static void ConvertToMethodGroup()
{
    List<string> firstNames = new() { "Jed", "Granny", "Elly-May" };

    firstNames.ForEach(name => Console.WriteLine(name));
    firstNames.ForEach(Console.WriteLine);

    List<Person> hillbillies = new()
    {
        new() {FirstName = "Jed", LastName = "Clampett"},
        new() {FirstName = "Elly-May", LastName = "Clampett"},
        new() {FirstName = "Granny", LastName = "Clampett"},
    };

    hillbillies.ForEach(Process.Hillbilly);
    hillbillies.ForEach(person => Process.Hillbilly(person));

}
```