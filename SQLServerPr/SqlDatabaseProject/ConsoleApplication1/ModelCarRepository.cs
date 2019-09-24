using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ModelCarRepository : Repository<ModelCar>
    {
        public override void Create(ModelCar obj)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var table = objDataContext.GetTable<ModelCar>();
                table.InsertOnSubmit(obj);
                objDataContext.SubmitChanges();
            }
        }

        public override void DeleteById(int id)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var obj = objDataContext.model_cars.Single(element => element.id == id);
                objDataContext.model_cars.DeleteOnSubmit(obj);
                objDataContext.SubmitChanges();
            }
        }

        public override void Update(ModelCar obj)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var mc = objDataContext.model_cars.Single(element => element.id == obj.id);
                mc.model = obj.model;
                objDataContext.SubmitChanges();
            }


        }
    }
}
