using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string firstValue = Console.ReadLine();
      int firstInput = Convert.ToInt32(firstValue);

      Console.WriteLine("Give the second number!");
      string secondValue = Console.ReadLine();
      int secondInput = Convert.ToInt32(secondValue);

      double average = (firstInput + secondInput) / 2.0;
      Console.WriteLine("The average is " + average);

      // Write your code here:

    }
  }
}
