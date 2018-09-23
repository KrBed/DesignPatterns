using System;

namespace StrategyPattern.FlyBeheviours
{
    public class NoFlying : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm not flying");
        }
    }
}
