using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Table(Name = "model_car")]
    public class ModelCar : AbstractModel
    { 
        public ModelCar(int id, string model)
        {
            this.id = id;
            this.model = model;
        }
        public ModelCar()
        {
        }
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = false)]
#pragma warning disable CS0108 // 'ModelCar.id' hides inherited member 'AbstractModel.id'. Use the new keyword if hiding was intended.
        public int id { get; set; }
#pragma warning restore CS0108 // 'ModelCar.id' hides inherited member 'AbstractModel.id'. Use the new keyword if hiding was intended.
        [Column(Name = "model")]
        public string model { get; set; }

        public override string ToString()
        {
            return this.id + " " + this.model;
        }
    }
}
