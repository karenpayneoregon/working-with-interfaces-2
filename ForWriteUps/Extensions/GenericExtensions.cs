using System;

namespace ForWriteUps.Extensions
{
    public static class GenericExtensions
    {
    
        public static void IterateClassProperties<T>(this T sender) where T : class
        {
            foreach (var propertyInfo in sender.GetType().GetProperties())
            {
                if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    Console.WriteLine($"{propertyInfo.Name.FirstPart(),10}: {((DateTime)propertyInfo.GetValue(sender, null)),-20:d} {propertyInfo.PropertyType.ToString().RemoveSystem()}");
                }
                else
                {
                    Console.WriteLine($"{propertyInfo.Name.FirstPart(),10}: {propertyInfo.GetValue(sender, null),-20} {propertyInfo.PropertyType.ToString().RemoveSystem()}");
                }
            }
        }
    }
}