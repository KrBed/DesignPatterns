using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        protected IFlyBehaviour flyingBehaviour;
        protected IQuackBehaviour quackingBehaviour;

        public abstract void Display();

        public  void MakeFly()
        {
            try
            {
                this.flyingBehaviour.Fly();
            }
            catch (Exception e)
            {
                Console.WriteLine(e + " there is no implementation of duck fly");               
            }
           
        }
        public void MakeQuack()
        {
            try
            {
                this.quackingBehaviour.Quack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "there is no flying implementation");
               
            }
         
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
