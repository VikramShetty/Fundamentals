using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
  public class SuperefficientEngine : Engine
  {
    public SuperefficientEngine()
    {
    }

    protected SuperefficientEngine(Engine otherEngine)
      : base(otherEngine)
    {
    }

    public override Engine makeCopy()
    {
      return new SuperefficientEngine(this);
    }
  }
}
