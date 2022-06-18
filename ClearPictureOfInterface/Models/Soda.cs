using System;

namespace ClearPictureOfInterface.Models
{
    public class Soda : MenuItem
    {
        public override void BringToTable()
        {
            Console.WriteLine($"\t{nameof(Soda)}");
        }
    }
}