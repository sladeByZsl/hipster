using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ObserverDesignPatent.Berverage;
using ObserverDesignPatent.Decorator;
using ObserverDesignPatent.Test;

namespace ObserverDesignPatent
{
    class Program
    {
        static void Main(string[] args)
        {
            //MemoryStream ms=new MemoryStream();
            //FileStream fs=new FileStream();
            //NetworkStream ns=new NetworkStream();

            //BeverageBase beverage=new Espresso();
            //beverage=new Mocha(beverage);
            //beverage = new Mocha(beverage);
            //beverage = new Whip(beverage);
            //Console.WriteLine(beverage.getDescription()+" and money is "+beverage.cost());
            //Console.WriteLine(beverage.getGG());

            BaseClass classOne = new BaseClass();
           Console.WriteLine(classOne.ToString());
        }
    }
}
