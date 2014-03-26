using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatent.Berverage
{
    public class Espresso : BeverageBase
    {
        public Espresso()
        {
            description = "Espresso";
        }
        
        public override double cost()
        {
            return 1.99;
        }
    }
}
