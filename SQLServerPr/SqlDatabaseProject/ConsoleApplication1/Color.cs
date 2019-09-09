using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Table(Name = "color")]
    class Color
    {
        [Column(Name = "id")]
        public int id { get; set; }
        [Column(Name = "color")]
        public string color { get; set; }


        public override string ToString()
        {
            return this.id + ": " + this.color;
        }

    }
}
