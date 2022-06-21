using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForWriteUps.Interfaces
{
    public class TaxpayerOperations : IModelEntity<Taxpayer>
    {
        public Taxpayer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Taxpayer Update(Taxpayer model)
        {
            throw new NotImplementedException();
        }

        public Taxpayer Add(Taxpayer model)
        {
            throw new NotImplementedException();
        }

        public Taxpayer Delete(int id)
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

        public List<Taxpayer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}