namespace ForWriteUps.Models.Base
{
    public abstract class MustInitialize1<T>
    {
        protected MustInitialize1(T minParameter, T maxParameter)
        {
            MinValue = minParameter;
            MaxValue = maxParameter;
        }

        public T MinValue { get; set; }
        public T MaxValue { get; set; }
    }
}