using System;

namespace ForWriteUps.Models.Base
{
    public abstract class MustInitialize2<T>
    {
        protected MustInitialize2(T identifier)
        {
            Identifier = identifier;
            Console.WriteLine($"\tIn {typeof(MustInitialize2<>).Name} constructor");
        }

        /// <summary>
        /// Primary key
        /// </summary>
        public T Identifier { get; set; }
    }

    public abstract class Initializer<T>
    {
        protected Initializer(T identifier)
        {
            Identifier = identifier;
        }

        /// <summary>
        /// Primary key
        /// </summary>
        public T Identifier { get; set; }
    }
}