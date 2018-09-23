using System;

namespace StrategyPattern.QuackBeheviours
{
    public class NoQuacking : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("No Quacking"); 
        }
    }
}
