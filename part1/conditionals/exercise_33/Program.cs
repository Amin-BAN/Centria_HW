using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first string:");
      string firstinput = Console.ReadLine();

      Console.WriteLine("Give the second string:");
      string secondinput = Console.ReadLine();

      if (firstinput == secondinput)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }
      // Write your code here:

    }
  }
}
