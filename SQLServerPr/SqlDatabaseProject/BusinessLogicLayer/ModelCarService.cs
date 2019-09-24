using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

        internal class ModelCarService : Service<ModelCar>
        {
            public ModelCarService()
            {
                this.repository = new ModelCarRepository();
            }
        }
    
}
