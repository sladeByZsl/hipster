using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatent.Berverage
{
    public class HouseBlend:BeverageBase
    {
        public override double cost()
        {
            return 0.89;
        }

        public HouseBlend()
        {
            description = "HouseBlend";
        }

    }
}
