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
            //DbDataContextDataContext dbda = new DbDataContextDataContext();

            Repository<Color> repositoryColor = new Repository<Color>();
            var listColors = repositoryColor.GetListAll(obj => true);
            var l = listColors.ToArray();
            for (int i = 0; i <= 2; i++) {
                Console.Write(l[i] + " ");
            }
          /*  foreach (var i in listColors)
            {
                Console.Write(i + " ");

            }*/
            //System.Console.WriteLine();
      /*var colors = from color in dbda.colors
                   select new
                   {
                       color.id,
                       color.color1
                   };
      foreach (var i in colors)
      {
          Console.Write(i + " ");
      }*/
      Console.ReadKey();
        }
    }
}
