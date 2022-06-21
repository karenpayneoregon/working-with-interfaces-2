using System;

namespace ForWriteUps.Classes
{
    static class TryOut
    {
        static void AgeOfPerson()
        {
            DateTime dateOfBirth = new(1956, 9, 24);
            Console.WriteLine(dateOfBirth.GetAge());
        }

    }
}