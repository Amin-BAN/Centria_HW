using System;

namespace exercise_22
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

      Console.WriteLine("Give the third number!");
      string thirdValue = Console.ReadLine();
      int thirdInput = Convert.ToInt32(thirdValue);

      double average = (firstInput + secondInput + thirdInput) / 3.0;
      Console.WriteLine("The average is " + average);


      // Write your code here:

    }
  }
}
