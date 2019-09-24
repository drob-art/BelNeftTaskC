using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

        internal class GosNumberService : Service<GosNumber>
        {
            public GosNumberService()
            {
                this.repository = new GosNumberRepository();
            }
        }
    
}
