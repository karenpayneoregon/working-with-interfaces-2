using System;
using System.Reflection;
using System.Runtime.CompilerServices;
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
    }
}
