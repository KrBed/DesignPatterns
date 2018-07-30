using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
