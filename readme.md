# How to properly learn how to code with C#

Some of this advice is for any language in Microsoft Visual Studio ecosystem.

| Do/Do not        | Tips |
|:------------- |:------------- |
| :heavy_check_mark: | Forget about starting with code, start by learn using [GitHub in Visual Studio](https://visualstudio.microsoft.com/vs/github/). Well we do need some code but will get to that. |
| :heavy_check_mark: | Get to know [Visual Studio Solution Explorer](https://docs.microsoft.com/en-us/visualstudio/ide/use-solution-explorer?view=vs-2022) |
| :heavy_check_mark: | Visual Studio [Manage project and solution properties](https://docs.microsoft.com/en-us/visualstudio/ide/managing-project-and-solution-properties?view=vs-2022)
| :heavy_check_mark: | Read Microsoft documentation on the anatomy of a Visual Studio solution. Once structuring of projects within a solution are understood this assist with proper coding. |
| :heavy_check_mark: | Read documentation on using solution folders in a Visual Studio solution which assist in segmenting various types of project from each other. |
| :heavy_check_mark: | Forget about starting to code with any project type other than a console project |
| :heavy_check_mark: | Don't be cheap if serious about learn to work with C#. Sure there are plenty of free courses on the web to learn from. There are downsides to free courses, anyone can post a free course which means they may or may not be correct. Instead get a subscription to Pluralsight. Once you have a Pluralsight subscription use their AI evaluation to assist your current skill and go with recommended courses. |
|  | Good courses will lead you into learning about proper coding using proper OOP by providing the basics and not go overboard. |
| :heavy_check_mark: | Learn small parts of coding then take time to experiment. For instance, working with strings, work with case and case insensitive logic statements e.g. does a string contain a word in the same case or perhaps mix-case. DateTime, this topic someone just starting out could spend hours or even days learning about. Take time as it will serve you well down the road. |
| :x: | Do not think unit testing is not for you. Unit testing can save countless time while initially coding an application along with proving or disproving what caused a runtime bug down the road. |
| :heavy_check_mark: | Constantly challenge your skills. A good way to do this is at least once a day or once a week traverse questions on Stackoverflow under the C# tag. See if you can answer them by writing out the solution for yourself. If comfortable with sharing your solution make sure it's perfect before posting. |
| :x: | Do not glance over interfaces, learn about them and why you should consider using interfaces |
| :x: | Do not create classes that you are calling a constructor on unless there is a good reason, instead try and write code using static methods. |
| :x: | Do not write SQL statements directly in code, write SQL-Statements for SQL-Server in SSMS (SQL-Server Management Studio), Oracle in Oracle Developer or get a paid version of Toad. |
| :x: | Do not use string concatenation when writing SQL statements, use parameters. When using parameters always use Add not AddWithValue. |
| :x: | When writing SQL, if there are performance issues, use SQL-Server profiler in SSMS to figure why there are performance issues. Many times it's a badly written statement or missing indices. |
| :heavy_check_mark: | When working with Windows forms, avoid writing all your code in the form. First off, writing all code in a form means you can not easily share this code and next, as code base becomes larger it will be difficult to maintain |
| :heavy_check_mark:|For those starting with Windows Forms and moving to XAML based projects, avoid coding as done in Windows Forms as these technologies can support forms based coding yet are not truly designed to work as how you coded in forms projects. Take time to learn XAML from Microsoft documentation along with Pluralsight courses. |
| :x:| Never change from one project type to another just because, instead do so because it makes sense. |
| | |

# Let's look at Interfaces

TODO


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

## See also

[More on interfaces](https://github.com/karenpayneoregon/oed-working-with-interfaces)
