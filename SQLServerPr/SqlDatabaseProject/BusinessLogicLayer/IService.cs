using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IService <T>where T : AbstractModel
    {
        ICollection<T> GetListAll();
        T GetById(int id);
        void Update(T obj);

        void DeleteById(int id);

        void Create(T obj);


    }
}
