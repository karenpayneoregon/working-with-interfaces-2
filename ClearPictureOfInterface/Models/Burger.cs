using System;
using ClearPictureOfInterface.Interfaces;

namespace ClearPictureOfInterface.Models
{
    public class Burger : MenuItem, IFood
    {
        public override void BringToTable()
        {
            Console.WriteLine($"\t{nameof(Burger)}");
        }
        public void Cook()
        {
            Console.WriteLine($"\t{nameof(Burger)}");
        }
    }
}