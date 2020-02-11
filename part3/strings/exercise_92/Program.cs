using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = Convert.ToInt32(DateTime.Now.Year + 1);
      string text = ("");

      while (true)
      {
        string input = Console.ReadLine();

        if ( input == "" )
        {
          break;
        }
        string[] pieces = input.Split(",");

        if ( oldest > Convert.ToInt32(pieces[1]) )
        {
          oldest = Convert.ToInt32(pieces[1]);
        }
        if ( text.Length < pieces[0].Length )
        {
          text = pieces[0];
        }
      }
      int old = ( 2020 - oldest );
      Console.WriteLine("Longest name: " + text);
      Console.WriteLine("Highest age: " + old);

    }
  }
}



