using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatent
{
    public abstract class BeverageBase
    {
        
        public abstract double cost();
        //private string name;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        //public abstract string Description { get;}

        protected string description="Unknown Beverage";
        //public string Description
        //{
        //    get
        //    {
        //        return description;
        //    }
        //}
        public virtual string getDescription()
        {
            return description;
        }

        public string getGG()
        {
            return "fdfdf";
        }
    }
}
