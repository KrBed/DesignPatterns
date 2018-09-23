using System;

namespace StrategyPattern.FlyBeheviours
{
    public class DuckFlying : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying couse have wings"); 
        }
    }
}
