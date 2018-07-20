using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        IFlyBehaviour flyingBehaviour;
        IQuackBehaviour quackingBehaviour;

        public abstract void Display();

        public void MakeFly()
        {
            flyingBehaviour.Fly();
        }
        public void MakeQuack()
        {
            quackingBehaviour.Quack();
        }
        public void SetFly(IFlyBehaviour flyBehaviour)
        {
            flyingBehaviour = flyBehaviour;
        }
        public void SetQuack(IQuackBehaviour quackBehaviour)
        {
            quackingBehaviour = quackBehaviour;
        }

    }
}
