namespace ForWriteUps.Models.Base
{
    public abstract class MustInitialize<T>
    {
        protected MustInitialize(T parameter)
        {
            MaxValue = parameter;
        }

        public T MaxValue { get; set; }
    }
}
