using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToInterface
{
  public class DecoyDuck : Duck
  {
    public DecoyDuck()
    {
      flyBehaviour = new FlyNoWay();
      quackBehaviour = new Quack();
    }
  }
}
