using System;

namespace exercise_19
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

       int sum = firstInput + secondInput;
       Console.WriteLine(firstInput + " + " + secondInput + " = " + sum);

      
      // Write your code here:

    }
  }
}
