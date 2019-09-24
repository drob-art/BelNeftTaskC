using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Table(Name = "color")]
    public class Color : AbstractModel
    {


        public Color(int id, string color)
        {
            this.id = id;
            this.color = color;
        }
        public Color()
        {
        }
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = false)]
#pragma warning disable CS0108 // 'Color.id' hides inherited member 'AbstractModel.id'. Use the new keyword if hiding was intended.
        public int id { get; set; }
#pragma warning restore CS0108 // 'Color.id' hides inherited member 'AbstractModel.id'. Use the new keyword if hiding was intended.
        [Column(Name = "color")]
        public string color { get; set; }


        public override string ToString()
        {
            return this.id + " " + this.color;
        }

    }
}
