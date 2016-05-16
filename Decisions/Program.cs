using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.WriteLine("Bob's Big Giveaway");
      Console.Write("Choose a door: 1, 2 or 3: ");
      string userValue = Console.ReadLine();

      string message = "";

      //Try the below styel of using constant 
      //before varible because that will avoid 
      //single equal error while comparing.
      if ("1" == userValue)
        message = "You won a new car!";
      else if ("2" == userValue)
        message = "You won a new boat!";
      else if ("3" == userValue)
        message = "You won a new cat!";
      else
        message = "Sorry, we didn't understand.";
     
      //Do not repeat your code block atleast in your method.
      //If the if condition has only one line. Remove the curly braces

      Console.WriteLine(message);
      Console.ReadLine();
      

      Console.WriteLine("Bob's Big Giveaway");
      Console.Write("Choose a door: 1 or 2: ");
      userValue = Console.ReadLine();

      message = ("1" == userValue) ? "boat" : "strand of lint";

      //Console.Write("You won a ");
      //Console.Write(message);
      //Console.Write(".");

      //CLEAN UP
      //Console.WriteLine("You won a {0}.",message);

      //Replace 2 value
      Console.WriteLine("You entered: {0}, therefore you won a {1}."
        , userValue, message);
      Console.ReadLine();
    }
  }
}
