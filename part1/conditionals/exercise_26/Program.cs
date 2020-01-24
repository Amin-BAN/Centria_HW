using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      int age = 1900;

      Console.WriteLine("Give your age:");

      string input = Console.ReadLine();

      int value = Convert.ToInt32(input);

      if (value < age)
      {
        Console.WriteLine("You're old");
      }

      // Write your code here:

    }
  }
}
