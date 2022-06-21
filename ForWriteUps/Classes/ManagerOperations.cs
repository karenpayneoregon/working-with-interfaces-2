using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForWriteUps.Interfaces
{
    public class ManagerOperations : IModelEntity<Manager>
    {
        public Manager GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Manager Update(Manager model)
        {
            throw new NotImplementedException();
        }
        public Manager Add(Manager model)
        {
            throw new NotImplementedException();
        }
        public Manager Delete(int id)
        {
            throw new NotImplementedException();
        }
        public int Commit()
        {
            throw new NotImplementedException();
        }
        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }
        public List<Manager> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}