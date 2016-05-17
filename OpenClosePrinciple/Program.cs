using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
  class Program
  {
    static void Main(string[] args)
    {
      Car car1 = new Car(2015, new TurboEngine());
      Console.WriteLine(car1.ToString());

      Car car2 = car1.makeCopy();
      Console.WriteLine(car2.ToString());

      Console.ReadKey();
    }
  }
}
