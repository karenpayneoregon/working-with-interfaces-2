using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace Lesson00
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = $"Code sample: {Assembly.GetCallingAssembly().GetName().Name} - starter";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
    }
}





