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
      Car car1 = new Car(2015, new Engine());
      Console.WriteLine(car1.ToString());

      Console.ReadKey();
    }
  }
}
