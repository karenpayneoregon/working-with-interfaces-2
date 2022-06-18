using System;

namespace ForWriteUps.Classes
{
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
    }
}