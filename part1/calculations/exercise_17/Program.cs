using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string first_Value = Console.ReadLine();
      int first_Input = Convert.ToInt32(first_Value);

      Console.WriteLine("Give the second number!");
      string second_Value = Console.ReadLine();
      int second_Input = Convert.ToInt32(second_Value);

      int sum = first_Input + second_Input;
      Console.WriteLine("The sum is " + sum);
      // Write your code here:

    }
  }
}
