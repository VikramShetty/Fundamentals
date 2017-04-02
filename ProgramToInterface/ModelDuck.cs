using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToInterface
{
  public class ModelDuck : Duck
  {
    public ModelDuck()
    {
      flyBehaviour = new FlyNoWay();
      quackBehaviour = new Quack();
    }
    public override string display()
    {
      return "I am Model Duck";
    }
  }
}
