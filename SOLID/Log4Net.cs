using System;

namespace SOLID
{
  public class Log4Net : ILogger
  {
    public void Information(string p, int id)
    {
      Console.Write("Log4net Information : " + id + " " + p + Environment.NewLine);
    }

    public void Debug(string p, int id)
    {
      Console.Write("Log4net Information : " + id + " " + p + Environment.NewLine);
    }
  }
}
