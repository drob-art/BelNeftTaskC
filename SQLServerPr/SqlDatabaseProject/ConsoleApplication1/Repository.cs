using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Repository<T> : IRepository<T> where T : class
    {
        protected DbDataContextDataContext dataContext = new DbDataContextDataContext();
        public void Create(T obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetListAll(Func<T, bool> exp)
        {
            return GetTable.Where<T>(exp);
        }

        public void Update(T obj)
        {
            //return GetTable.u
        }


        public virtual T CreateInstance()
        {
            T entity = Activator.CreateInstance<T>();
            GetTable.InsertOnSubmit(entity);
            return entity;
        }

        private System.Data.Linq.Table<T> GetTable
        {
            get { return dataContext.GetTable<T>(); }
        }
    }
}
