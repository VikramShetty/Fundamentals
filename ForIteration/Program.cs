using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
  class Program
  {
    static void Main(string[] args)
    {

      for (int i = 0; i < 10; i++)
      {
        if (7 == i)
        {
          Console.WriteLine("Found seven!");
          break;
        }
      }

      for (int myCounter = 0; myCounter < 12; myCounter++)
      {
        Console.WriteLine(myCounter);        
      }

      Console.ReadLine();
    }
  }
}
