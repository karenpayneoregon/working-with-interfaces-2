using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using ForWriteUps.Extensions;
using Force.DeepCloner;
using ForWriteUps.Interfaces;
using ForWriteUps.Models;
using ForWriteUps.Models.Base;

namespace ForWriteUps.Classes
{
    /// <summary>
    /// Used for write up in main readme file
    /// </summary>
    public class WorkOperations
    {
        public static void IterateHumans()
        {
            var humans = Mocking.List();
            foreach (var human in humans)
            {
                Console.WriteLine($"{human.GetType().Name,-12} {human.Id,-3}{human.FirstName,-12}{human.LastName,-12}{human.BirthDate:d}");
            }
        }

        public static void ComparerBuilderExample()
        {
            var builder = new ComparerBuilder<IHuman>();
            var comparer = builder
                .SortKey(human => human.LastName)
                .ThenKeyDescending(human => human.BirthDate)
                .Build();

            var list = Mocking.List();
            list.Sort(comparer);
            
        }

        /// <summary>
        /// IEnumerable generic
        /// </summary>
        public static void NotNullExample()
        {
            List<int?> list = new () { 1, null, 3, 4, 5 };

            var results = list.WhereNotNull();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            var values = new[] {"1", null,"3"}.WhereNotNull();

            foreach (var month in values)
            {
                Console.WriteLine($"'{month}'");
            }

        }

        /// <summary>
        /// https://github.com/force-net/DeepCloner
        /// https://stackoverflow.com/a/56933017/5509738
        /// </summary>
        public static void CloneWithDeepCloner()
        {
            Person person = new ()
            {
                PersonIdentifier = 1, 
                FirstName = "Karen", 
                LastName = "Payne", 
                BirthDate = new DateTime(1956,9,24)
            };


            Person deepCloned = person.DeepClone();

            Console.WriteLine($"person == deepCloned? {person == deepCloned}");

            person.PersonIdentifier = 2;
            person.BirthDate = DateTime.Now;
            deepCloned.FirstName = "Jane";

            person.IterateClassProperties();
            Console.WriteLine();
            deepCloned.IterateClassProperties();

        }

        /// <summary>
        /// You have choices, C# 8 and higher [^1] gets last element
        /// vs pre C# 8 value[value.Length - 1]
        /// </summary>
        [SuppressMessage("ReSharper", "All")]
        public static void TipTheHat()
        {
            int[] values = new[] { 10, 11, 12, 13 };
            Console.WriteLine(values[^1] == values[values.Length - 1]);
            Console.WriteLine($"{values[^1]}\t{values[values.Length - 1]}");
        }
    }

    public class OperationsWithDecimal : MustInitialize<decimal>
    {
        public OperationsWithDecimal(decimal parameter) : base(parameter)
        {
        }
    }

    public class OperationsWithInt : MustInitialize<int>
    {
        public OperationsWithInt(int parameter) : base(parameter)
        {
        }
    }

    public class OperationsWithTwoParams : MustInitialize1<int>
    {
        public OperationsWithTwoParams(int minParameter, int maxParameter) 
            : base(minParameter, maxParameter) {
        }

        public List<int> Range() => Enumerable.Range(MinValue, MaxValue +1).ToList();
    }

    /// <summary>
    /// Same as above, here let's say we are search in SQL-Server
    /// where keys are int, if Oracle we change to decimal
    ///
    /// See also <see cref="OracleOperations"/>
    /// 
    /// </summary>
    public class SqlServerOperations : MustInitialize2<int>
    {
        public SqlServerOperations(int identifier, [CallerMemberName] string caller = null) : base(identifier)
        {
            Console.WriteLine($"\tIn {nameof(SqlServerOperations)} called by [{caller}] ");
        }

        public IHuman Find()
        {
            return Mocking.List().FirstOrDefault(human => human.Id == Identifier);
        }
    }

    /// <summary>
    /// Mirror image of <see cref="SqlServerOperations"/>
    /// </summary>
    public class OracleOperations : MustInitialize2<decimal>
    {
        public OracleOperations(int identifier) : base(identifier)
        {
            // TODO
        }

        public IHuman Find()
        {
            throw new NotImplementedException();
        }
    }
    public class TestOperations
    {
        public static void Example1()
        {
            OperationsWithDecimal operations1 = new(1m);
            Console.WriteLine(operations1.MaxValue);

            OperationsWithInt operations2 = new(1);
            Console.WriteLine(operations2.MaxValue);

            OperationsWithTwoParams operations3 = new(10, 10);
            Console.WriteLine($"{operations3.MinValue}, {operations3.MaxValue}");
            Console.WriteLine($"{string.Join(",", operations3.Range())}");

            SqlServerOperations customerOperations = new(2);
            Console.WriteLine(customerOperations.Find().LastName);
        }
    }
}