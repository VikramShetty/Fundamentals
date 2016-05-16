using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
  public class TurboEngine : Engine
  {
    public TurboEngine()
    {
    }

    public TurboEngine(Engine otherEngine)
      : base(otherEngine)
    {
    }
  }
}
