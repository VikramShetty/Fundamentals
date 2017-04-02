using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToInterface
{
  public class RubberDuck : Duck
  {
    public RubberDuck()
    {
      flyBehaviour = new FlyNoWay();
      quackBehaviour = new Squeak();
    }
  }
}
