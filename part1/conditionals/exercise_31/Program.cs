using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string input = Console.ReadLine();
      int userinput = Convert.ToInt32(input);

      if (userinput % 2 == 0)
      {
        Console.WriteLine("It is even.");
      }
      else
      {
        Console.WriteLine("It is odd.");
      }
      // Write your code here:

    }
  }
}
