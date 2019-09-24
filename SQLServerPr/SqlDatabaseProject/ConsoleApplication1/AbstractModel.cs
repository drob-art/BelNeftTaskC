using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class AbstractModel
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = false)]
        public int id { get; set; }
    }
}
