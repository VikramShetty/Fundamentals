using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID
{
  public class LoggerConfiguration
  {
    public ILogger CreateLogger()
    {
      return new Log();
    }
  }
}
