using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public class HomeDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a home Duck");
        }
    }
}
