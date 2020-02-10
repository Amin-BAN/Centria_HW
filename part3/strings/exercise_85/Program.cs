using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
     

      Console.WriteLine("Enter username:");
      string input = Console.ReadLine();
      Console.WriteLine("Enter password:");
      string userinput = Console.ReadLine();

       if ( ( input == "alex" && userinput == "sunshine" ) | ( input == "emma" && userinput == "haskell" ) )
      {
        Console.WriteLine( "You have successfully logged in!" );
      }

      else 
      {
        Console.WriteLine( "Incorrect username or password!" );
      }


    }
  }
}

