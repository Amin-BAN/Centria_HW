using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string firstValue = Console.ReadLine();
      double firstInput = Convert.ToDouble(firstValue);

      Console.WriteLine("Give the second number!");
      string secondValue = Console.ReadLine();
      double secondInput = Convert.ToDouble(secondValue);

      double sum = firstInput + secondInput;
      double subtraction = firstInput - secondInput;
      double multiply = firstInput * secondInput;
      double average = firstInput / secondInput;

      Console.WriteLine(firstInput + " + " + secondInput + " = " + sum);
      Console.WriteLine(firstInput + " - " + secondInput + " = " + subtraction);
      Console.WriteLine(firstInput + " * " + secondInput + " = " + multiply);
      Console.WriteLine(firstInput + " / " + secondInput + " = " + average);

      // Write your code here:

    }
  }
}
