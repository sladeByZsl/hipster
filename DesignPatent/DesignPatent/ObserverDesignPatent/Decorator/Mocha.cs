using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatent.Decorator
{
    class Mocha : CondimentDecorator
    {
        private BeverageBase berverage;

        public override double cost()
        {
            return 20.0 + berverage.cost();
        }

        public Mocha(BeverageBase beverage)
        {
            this.berverage = beverage;
        }

        public override string getDescription()
        {
            return berverage.getDescription() + ",Mocha";
        }
    }
}
