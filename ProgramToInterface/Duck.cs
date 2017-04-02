using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToInterface
{
    public abstract class Duck
    {
      protected FlyBehaviour flyBehaviour;
      protected QuackBehaviour quackBehaviour;
      public string Swim()
      {
       return "All duck can swim!";
      }

      public string PerformFly()
      {
        return flyBehaviour.PerformFly();
      }

      public string PerformQuack()
      {
        return quackBehaviour.PerformQuack();
      }
    }
}
