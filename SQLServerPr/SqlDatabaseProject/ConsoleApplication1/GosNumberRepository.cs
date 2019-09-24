using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GosNumberRepository : Repository<GosNumber>
    {
        public override void Create(GosNumber obj)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var table = objDataContext.GetTable<GosNumber>();
                table.InsertOnSubmit(obj);
                objDataContext.SubmitChanges();
            }
        }

        public override void DeleteById(int id)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var obj = objDataContext.gos_numbers.Single(element => element.id == id);
                objDataContext.gos_numbers.DeleteOnSubmit(obj);
                objDataContext.SubmitChanges();
            }
        }

        public override void Update(GosNumber obj)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var gn = objDataContext.gos_numbers.Single(element => element.id == obj.id);
                gn.number = obj.number;
                gn.region = obj.region;
                gn.serial = obj.serial;
                gn.idColor = obj.idColor;
                gn.idModelCar = obj.idModelCar;
                objDataContext.SubmitChanges();
            }
        }
    }
}
