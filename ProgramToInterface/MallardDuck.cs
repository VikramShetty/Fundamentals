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
    }
  }
}
