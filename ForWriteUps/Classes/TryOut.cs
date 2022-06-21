using System;

namespace ForWriteUps.Classes
{
    /// <summary>
    /// Has nothing to do with interfaces
    /// </summary>
    static class TryOut
    {
        static void AgeOfPerson()
        {
            DateTime dateOfBirth = new(1956, 9, 24);
            Console.WriteLine(dateOfBirth.GetAge());
        }

    }
}