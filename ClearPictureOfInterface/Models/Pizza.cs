using System;
using ClearPictureOfInterface.Interfaces;

namespace ClearPictureOfInterface.Models
{
    public class Pizza : MenuItem, IFood
    {
        public override void BringToTable()
        {
            Console.WriteLine($"\t{nameof(Pizza)}");
        }

        public void Cook()
        {
            Console.WriteLine($"\t{nameof(Pizza)}");
        }
    }
}