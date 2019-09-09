using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IRepository <T>
    {
        IEnumerable<T> GetListAll(Func<T, bool> exp);
        T GetById(int id);
        void Update(T obj);

        void DeleteById(int id);

        void Create(T obj);


    }
}
