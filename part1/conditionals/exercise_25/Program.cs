using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      int number = 1984;

      Console.WriteLine("Give a number:");

      string input = Console.ReadLine();

      int value = Convert.ToInt32(input);

      if (value == number)
      {
        Console.WriteLine("Orwell");
      }

      // Write your code here:

    }
  }
}
