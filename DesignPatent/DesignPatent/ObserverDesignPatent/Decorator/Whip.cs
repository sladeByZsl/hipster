using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatent.Decorator
{
    public class Whip:BeverageBase
    {
        private BeverageBase berverage;
        public Whip(BeverageBase beverage)
        {
            this.berverage = beverage;
        }
        public override double cost()
        {
            return 30.0 + berverage.cost();
        }
        public override string getDescription()
        {
            return berverage.getDescription() + ",Whip";
        }
    }
}
