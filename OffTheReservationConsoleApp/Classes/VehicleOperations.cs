using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OffTheReservationConsoleApp.Converters;
using OffTheReservationConsoleApp.Interfaces;
using OffTheReservationConsoleApp.Models;

namespace OffTheReservationConsoleApp.Classes
{
    public class VehicleOperations
    {
        private static JsonSerializerOptions _jsonSerializerOptions =>
            new() { WriteIndented = true, };
        private static IVehicle[] _vehicles =>
            new IVehicle[]
            {
                new Car {Make = "Audi", Model = "A4", NumberOfWheels = 4},
                new Bicycle {Manufacturer = "Schwinn", NumberOfWheels = 2}
            };
        public static void SerializeFirstAttempt()
        {

            var types = JsonSerializer.Serialize(
                _vehicles,
                _jsonSerializerOptions);

            Console.WriteLine(types);
            File.WriteAllText("Wrong.json", types);

        }

        public static void SerializeDoneRight()
        {
            var fileName = "Right.json";

            var types = JsonSerializer.Serialize(_vehicles, new JsonSerializerOptions
            {
                Converters = { new VehicleConverter() }, WriteIndented = true
            });

            Console.WriteLine(types);

            File.WriteAllText(fileName, types);

            // read not implemented yet
            var vehicles = JsonSerializer.Deserialize<List<IVehicle>>(
                File.ReadAllText(fileName), 
                new JsonSerializerOptions()
                {
                    Converters = { new VehicleConverter() }
                });


        }


    }
}
