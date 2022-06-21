using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForWriteUps.Interfaces
{
    /// <summary>
    /// Use this interface in a class which performs operations for a specific model
    /// </summary>
    /// <typeparam name="T">model</typeparam>
    public interface IModelEntity<T>
    {
        T GetById(int id);
        T Update(T model);
        T Add(T model);
        T Delete(int id);
        int Commit();
        Task<int> CommitAsync();
        List<T> GetAll();
    }
}