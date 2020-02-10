using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
      string text = "true";
      string write = "trueish";

      Console.Write("Give a string: ");
      string input = Console.ReadLine();

      if ( input == text )
      {
        Console.WriteLine( "You got it right!" );
      } 
      else 
      {
        Console.WriteLine( "Try again!" );
      }


    }
  }
}

