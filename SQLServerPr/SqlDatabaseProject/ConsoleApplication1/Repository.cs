using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Repository<T> : IRepository<T> where T : AbstractModel
    {
        public Repository()
        {
        }
        public abstract void Create(T obj);

        public T GetById(int id)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var table = objDataContext.GetTable<T>();
                return table.Where<T>(obj => obj.id == id).DefaultIfEmpty().Single();
            }
        }

        public ICollection<T> GetListAll()
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var table = objDataContext.GetTable<T>();
                return table.Where<T>(obj => true).ToList();
            }
        }

        public abstract void Update(T obj);



        public abstract void DeleteById(int id);


    }
}
