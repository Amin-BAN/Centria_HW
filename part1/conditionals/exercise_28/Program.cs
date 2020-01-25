using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
       int age = 18;

      Console.WriteLine("How old are you?");

      string input = Console.ReadLine();

      int value = Convert.ToInt32(input);

      if (age < value)
      {
        Console.WriteLine("You're an adult!");
      }
      else
      {
        Console.WriteLine("You're under age!");
      }

      // Write your code here:

    }
  }
}
