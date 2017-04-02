using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToInterface
{
  public class MuteQuack : QuackBehaviour
  {
    public string PerformQuack()
    {
      return "<< Silence >>";
    }
  }
}
