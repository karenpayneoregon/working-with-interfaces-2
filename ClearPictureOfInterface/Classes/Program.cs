using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using ClearPictureOfInterface.LanguageExtensions;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace ClearPictureOfInterface
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = $"Code sample: {Assembly.GetCallingAssembly().GetName().Name.SplitCamelCase()}";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
    }
}





