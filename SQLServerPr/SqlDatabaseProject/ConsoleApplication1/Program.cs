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

            IRepository<Color> repositoryColor = new ColorRepository();

            Color newColor = new Color(11112, "Vitalic");
            repositoryColor.Create(newColor);
            
            //repositoryColor.DeleteById(4);

            Color dsdsf = new Color(2, "222111555");
            repositoryColor.Update(dsdsf);

            //var listColorsById = repositoryColor.GetById(2);
            //Console.WriteLine(listColorsById);

            ICollection<Color> listColors = repositoryColor.GetListAll();
            foreach (var l in listColors)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();
        }
    }
}
