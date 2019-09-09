using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ColorRepository : IRepository<Color>
    {
        protected DbDataContextDataContext dataContext = new DbDataContextDataContext();

        public void Create(Color obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Color GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Color> GetListAll(Func<Color, bool> exp)
        {
            return GetTable.Where<Color>(exp);
        }

        public void Update(Color obj)
        {
            throw new NotImplementedException();
        }

        public virtual Color CreateInstance()
        {
            Color entity = Activator.CreateInstance<Color>();
            GetTable.InsertOnSubmit(entity);
            return entity;
        }

        private System.Data.Linq.Table<Color> GetTable
        {
            get { return dataContext.GetTable<Color>(); }
        }
    }
}
