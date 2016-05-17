using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
  public abstract class Engine
  {
    public Engine()
    {
    }

    protected Engine(Engine otherEngine)
    {
    }

    public override string ToString()
    {
      return this.GetType().Name + ":" + this.GetHashCode().ToString();
    }

    public abstract Engine makeCopy();

  }
}
