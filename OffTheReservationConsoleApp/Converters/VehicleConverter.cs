using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OffTheReservationConsoleApp.Interfaces;
using OffTheReservationConsoleApp.Models;

namespace OffTheReservationConsoleApp.Converters
{
    public class VehicleConverter : JsonConverter<IVehicle>
    {
        public override IVehicle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, IVehicle value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case null:
                    JsonSerializer.Serialize(writer, (IVehicle)null, options);
                    break;
                default:
                {
                    var type = value.GetType();
                    JsonSerializer.Serialize(writer, value, type, options);
                    break;
                }
            }
        }
    }
}