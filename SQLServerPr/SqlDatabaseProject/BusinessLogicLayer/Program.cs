using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IService<Color> colorService = new ColorService();

            Color newColor = new Color(33, "Vitalic");
            //colorService.Create(newColor);

            //colorService.DeleteById(0);

            Color dsdsf = new Color(33, "555");
            //colorService.Update(dsdsf);

            var listColorsById = colorService.GetById(33);
            Console.WriteLine(listColorsById);

            ICollection<Color> listColors = colorService.GetListAll();
            foreach (var l in listColors)
            {
                Console.WriteLine(l);

            }
            Console.ReadKey();
        }
    }
}
