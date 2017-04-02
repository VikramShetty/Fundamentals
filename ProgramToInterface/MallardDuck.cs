using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToInterface
{
  public class MallardDuck : Duck
  {
    public MallardDuck()
    {
      flyBehaviour = new FlyWithWings();
      quackBehaviour = new Quack();
    }

    public override string display()
    {
      return "I am a real Mallard Duck";
    }
  }
}
