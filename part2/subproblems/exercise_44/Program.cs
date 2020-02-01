using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      int input = Convert.ToInt32(Console.ReadLine());
      int input1 = Convert.ToInt32(Console.ReadLine());

      if (input > input1)
      {
        Console.WriteLine(input + " is greater than " + input1 + ".");
      }
      else if (input < input1)
      {
        Console.WriteLine(input + " is less than " + input1 + ".");
      }
      else
      {
        Console.WriteLine(input + " is equal to " + input1 +".");
      }

    }
  }
}
