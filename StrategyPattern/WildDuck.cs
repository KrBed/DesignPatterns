using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class WildDuck : Duck
    {
        //private IFlyBehaviour _fb;
        //private IQuackBehaviour _qb;
        public WildDuck(IFlyBehaviour fb , IQuackBehaviour qb)
        {
            flyingBehaviour = fb;
            quackingBehaviour = qb;
        }

        public override void Display()
        {
            Console.WriteLine("I'm a wild duck");
        }

    }
}
