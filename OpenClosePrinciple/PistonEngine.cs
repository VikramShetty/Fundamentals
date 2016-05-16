using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
  public class PistonEngine : Engine
  {
    public PistonEngine()
    {
    }

    public PistonEngine(Engine otherEngine)
      : base(otherEngine)
    {
    }

    public override Engine makeCopy()
    {
      return new PistonEngine(this);
    }
  }
}
