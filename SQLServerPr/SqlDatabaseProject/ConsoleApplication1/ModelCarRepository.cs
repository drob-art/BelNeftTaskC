using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ModelCarRepository : IRepository<ModelCar>
    {
        public void Create(ModelCar obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public ModelCar GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ModelCar> GetListAll(Func<ModelCar, bool> exp)
        {
            throw new NotImplementedException();
        }

        public void Update(ModelCar obj)
        {
            throw new NotImplementedException();
        }
    }
}
