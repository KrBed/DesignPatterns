using StrategyPattern.FlyBeheviours;
using StrategyPattern.QuackBeheviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WildDuck duck = new WildDuck(new DuckFlying(), new WildDuckQuacking());
            duck.MakeFly();
            duck.MakeQuack();
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
