using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      // Wrong Way to deal with multiple values in collection
      // of same domain / same type
      int number1 = 4;
      int number2 = 8;
      int number3 = 15;
      int number4 = 16;
      int number5 = 23;

      if (number1 == 16)
      { }
      else if (number2 == 16)
      { }
      else if (number3 == 16)
      { }
      else if (number4 == 16)
      { }
      else if (number5 == 16)
      { }

      int[] numbers = new int[5];
      numbers[0] = 4;
      numbers[1] = 8;
      numbers[2] = 15;
      numbers[3] = 16;
      numbers[4] = 23;

      Console.WriteLine(numbers[1]);
      Console.WriteLine(numbers.Length);

      // Simple way to declare an array

      int[] digits = new int[]{ 4, 8, 15, 16, 23, 42};

      string[] names = new string[] { "Eddie", "Alex", "Bob", "Micheal", "David" };
      for (int i = 0; i < names.Length; i++)
      {
        Console.WriteLine(names[i]);
      }
      Console.WriteLine(" ");
      Console.WriteLine("For each");
      foreach (string name in names)
      {
        Console.WriteLine(name);
      }

      Console.WriteLine(" ");
      Console.WriteLine("Reverse char");
      string zig = "You can get what you want out of life " +
      " if you help enough other people get what they want.";

      char[] charArray = zig.ToCharArray();
      Array.Reverse(charArray);
      foreach (var zigChar in charArray)
      {
        Console.Write(zigChar);
      }
      Console.ReadLine();
    }
  }
}
