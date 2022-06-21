using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForWriteUps.Interfaces;
using ForWriteUps.Models;

namespace ForWriteUps.Classes
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