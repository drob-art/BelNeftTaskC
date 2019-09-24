using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ColorRepository : Repository<Color>
    {

        public override void DeleteById(int id)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var obj = objDataContext.colors.Single(element => element.id == id);
                objDataContext.colors.DeleteOnSubmit(obj);
                objDataContext.SubmitChanges();
            }
        }

        public override void Update(Color obj)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var c = objDataContext.colors.Single(element => element.id == obj.id);
                c.color1 = obj.color;
                objDataContext.SubmitChanges();
            }
        }
        public override void Create(Color obj)
        {
            using (DbDataContextDataContext objDataContext = new DbDataContextDataContext())
            {
                var table = objDataContext.GetTable<Color>();
                table.InsertOnSubmit(obj);
                objDataContext.SubmitChanges();
            }
        }
    }
}
