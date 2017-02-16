using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID
{
  public interface ILogger
  {
    void Information(string message, int id);

    void Debug(string message, int id);
  }
}
