using OffTheReservationConsoleApp.Interfaces;

namespace OffTheReservationConsoleApp.Models
{
    public class Bicycle : IVehicle
    {
        public string Manufacturer { get; set; }
        public int NumberOfWheels { get; set; }
    }
}