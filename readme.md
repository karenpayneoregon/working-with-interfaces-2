# About 

- Basics for using
  - [Interfaces](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface): An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface. *A lead developer writes interfaces for code logic and provides them to other developers to use.*
  - [Abstract](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract) classes: Use the abstract modifier in a class declaration to indicate that a class is intended only to be a `base class` of other classes, not instantiated on its own. Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class.

## Interface benefits

The main benefit is about code readability, code maintainability and code "semantics".

- **Code readability**: An interface constitutes a declaration about intentions. It defines a capability of your class, what your class is capable of doing. 
- **Code semantics**: By providing interfaces and implementing them you're actively separating concepts in a similar way HTML and CSS does. A class is a concrete implementation of an "object class" some way of representing the reality by modeling general properties of real life objects or concepts. An interface define a behavioral model, a definition of what an object can do. Separating those concepts keeps the semantics of your code more clear.
- **Code maintainability**: Interfaces helps to reduce coupling and therefore allow you to easily interchange implementations for the same concept without the underlying code being affected. 
- Implement [Dependency injection](https://en.wikipedia.org/wiki/Dependency_injection)

```csharp
List<IBaseEntity> list = new()
{
    new Customer() { CustomerIdentifier = 1, Name = "SomeCustomer", ContactIdentifier = 2 },
    new Car() { CarId = 1, Name = "Car 1" },
};
```
