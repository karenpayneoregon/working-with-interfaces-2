using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using ForWriteUps.Classes;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace ForWriteUps
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = $"Code sample: {Assembly.GetCallingAssembly().GetName().Name}";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }

        private static void AgeOfPerson()
        {
            DateTime dateOfBirth = new(1956, 9, 24);
            Console.WriteLine(dateOfBirth.GetAge());
        }
    }
}
