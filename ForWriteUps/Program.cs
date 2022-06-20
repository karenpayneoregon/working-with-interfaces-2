using System;
using ForWriteUps.Classes;

namespace ForWriteUps
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //WorkOperations.CloneWithDeepCloner();
            //AgeOfPerson();


            Console.ReadLine();
        }

        static void AgeOfPerson()
        {
            DateTime dateOfBirth = new(1956, 9, 24);
            Console.WriteLine(dateOfBirth.GetAge());
        }
    }


}
