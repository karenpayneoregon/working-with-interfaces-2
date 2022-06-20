using System;
using System.Collections.Generic;
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


    public class Manager : IHuman
    {
        public int ManagerIdentifier { get; set; }
        public int Id => ManagerIdentifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

    }

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
    public class Taxpayer : IHuman
    {
        public int TaxpayerIdentifier { get; set; }
        public int Id => TaxpayerIdentifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }

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