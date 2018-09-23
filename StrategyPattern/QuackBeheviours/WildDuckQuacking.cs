using System;

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
