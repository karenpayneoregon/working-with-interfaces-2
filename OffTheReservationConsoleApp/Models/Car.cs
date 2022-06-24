using OffTheReservationConsoleApp.Interfaces;

namespace OffTheReservationConsoleApp.Models
{
    public class Car : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
    }
}