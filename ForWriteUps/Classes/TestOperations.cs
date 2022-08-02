using System;

namespace ForWriteUps.Classes
{
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

            Console.WriteLine("SQL-Server");
            SqlServerOperations customerOperations = new(2);
            Console.WriteLine(customerOperations.Find().LastName);

            Console.WriteLine("Oracle");
            OracleOperations customerOperations1 = new(2m);
            Console.WriteLine(customerOperations1.Find().LastName);
        }
    }
}