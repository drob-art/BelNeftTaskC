using System;
using System.Collections.Generic;


namespace ConsoleApplication1
{
    class Service<T> : IService<T> where T : class
    {
        IRepository<T> repository;
        public void Create(T obj)
        {
           repository.Create(obj);
        }

        public void DeleteById(int id)
        {
            repository.DeleteById(id);
        }

        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<T> GetListAll(Func<T, bool> exp)
        {
            return repository.GetListAll(exp);
        }

        public void Update(T obj)
        {
            repository.Update(obj);
        }


    }
}
