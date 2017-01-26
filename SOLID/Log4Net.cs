
using System;

namespace SOLID
{
  public class Log4Net
  {
    public static void Information(string p, int id)
    {
      Console.Write("Log4net Information : " + id + " " + p + Environment.NewLine);
    }

    public static void Debug(string p, int id)
    {
      Console.Write("Log4net Information : " + id + " " + p + Environment.NewLine);
    }
  }
}
