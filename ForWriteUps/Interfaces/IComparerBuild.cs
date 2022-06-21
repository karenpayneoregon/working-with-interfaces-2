using System.Collections.Generic;

namespace ForWriteUps.Interfaces
{
    public interface IComparerBuild<T>
    {
        IComparer<T> Build();
    }
}