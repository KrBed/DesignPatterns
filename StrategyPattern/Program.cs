using StrategyPattern.FlyBeheviours;
using StrategyPattern.QuackBeheviours;
using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WildDuck duck = new WildDuck(new DuckFlying(), new WildDuckQuacking());
            duck.MakeFly();
            duck.MakeQuack();         
            HomeDuck hd = new HomeDuck();
            hd.MakeFly();
            hd.MakeQuack();
            hd.Display();
            Console.ReadKey();
        }
    }
}
