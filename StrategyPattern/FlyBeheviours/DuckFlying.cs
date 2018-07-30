using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
