using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.QuackBeheviours
{
    public class WildDuckQuacking : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Wild Duck Quacking"); 
        }
    }
}
