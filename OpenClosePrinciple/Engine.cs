using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
  public class Engine
  {
    public Engine()
    {
    }

    public Engine(Engine otherEngine)
    {
    }

    public override string ToString()
    {
      return this.GetType().Name + ":" + this.GetHashCode().ToString();
    }
  }
}
