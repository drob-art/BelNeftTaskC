using System;
using System.Collections.Generic;


namespace ConsoleApplication1
{
    public class Service<T> : IService<T> where T : AbstractModel
    {
        protected IRepository<T> repository;

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

        public ICollection<T> GetListAll()
        {
            return repository.GetListAll();
        }

        public void Update(T obj)
        {
            repository.Update(obj);
        }


    }
}
