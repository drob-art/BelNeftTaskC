using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Table(Name = "gos_number")]
    public class GosNumber : AbstractModel
    {
        public GosNumber(int id, string number, string serial, string region, int idModelCar, int idColor)
        {
            this.id = id;
            this.number = number;
            this.serial = serial;
            this.region = region;
            this.idModelCar = idModelCar;
            this.idColor = idColor;
        }

        public GosNumber()
        {
        }
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = false)]
#pragma warning disable CS0108 // 'GosNumber.id' hides inherited member 'AbstractModel.id'. Use the new keyword if hiding was intended.
        public int id { get; set; }
#pragma warning restore CS0108 // 'GosNumber.id' hides inherited member 'AbstractModel.id'. Use the new keyword if hiding was intended.
        [Column(Name = "number")]
        public string number { get; set; }
        [Column(Name = "serial")]
        public string serial { get; set; }
        [Column(Name = "region")]
        public string region { get; set; }
        [Column(Name = "idModelCar")]
        public int idModelCar { get; set; }
        [Column(Name = "idColor")]
        public int idColor { get; set; }

        public override string ToString()
        {
            return this.id + " " + this.number + " " + this.serial + " " + this.region + " " + this.idModelCar + " " + this.idColor;
        }
    }
}
