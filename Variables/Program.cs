﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      
      int x;
      int y;

      x = 7;
      y = x + 3;
      Console.WriteLine(y);
      Console.ReadKey();
      

      Console.WriteLine("What is your name?");
      Console.Write("Type your first name: ");
      //Give a meaningful name to variable.
      string myFirstName;
      myFirstName = Console.ReadLine();

      //string myLastName;
      Console.Write("Type your last name: ");
      //myLastName = Console.ReadLine();

      //Initialization helps you to put the 
      //variable into a valid states quickly.
      string myLastName = Console.ReadLine();

      Console.WriteLine("Hello, " + myFirstName
        + " " +myLastName + ".");

      Console.ReadKey();

      //Avoid high degree of confusion.
      //Avoid clever code.
    }
  }
}
