using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string first_input = Console.ReadLine();
      int firstValue = Convert.ToInt32(first_input);

      Console.WriteLine("Give the second number!");
      string second_input = Console.ReadLine();
      int secondValue = Convert.ToInt32(second_input);

      if (firstValue < secondValue)
      {
        Console.WriteLine("The larger number is " + secondValue + "!");
      }
      else if (firstValue > secondValue)
      {
        Console.WriteLine("The larger number is " + firstValue + "!");
      }
      else
      {
        Console.WriteLine("They are equal!");
      }
      // Write your code here:

    }
  }
}
