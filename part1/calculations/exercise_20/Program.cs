using System;

namespace exercise_20
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

      int multiply = firstInput * secondInput;
      Console.WriteLine(firstInput + " * " + secondInput + " = " + multiply);

      // Write your code here:

    }
  }
}
