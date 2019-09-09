using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GosNumberRepository : IRepository<GosNumber>
    {
        public void Create(GosNumber obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public GosNumber GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GosNumber> GetListAll(Func<GosNumber, bool> exp)
        {
            throw new NotImplementedException();
        }

        public void Update(GosNumber obj)
        {
            throw new NotImplementedException();
        }
    }
}
