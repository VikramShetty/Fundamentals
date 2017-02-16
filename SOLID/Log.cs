using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
  class Log : ILogger
  {
    public void Information(string p, int id)
    {
      Console.Write("Log Information : " + id + " " + p + Environment.NewLine);
    }

    public void Debug(string p, int id)
    {
      Console.Write("Log Debug : " + id + " " + p + Environment.NewLine);
    }
  }
}
