using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IRepository <T>
    {
        T GetById(int id);
        void Update(T obj);

        void DeleteById(int id);

        void Create(T obj);
    }
}
