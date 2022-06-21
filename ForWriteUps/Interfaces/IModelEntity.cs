﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForWriteUps.Interfaces
{
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