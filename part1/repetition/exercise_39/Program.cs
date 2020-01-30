using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        string userinput = Console.ReadLine();
        int input = Convert.ToInt32(userinput);

        if (input == 0)
        {
          break;
        }
        else
        {
          sum = sum + input;
        }
      }
      {
        Console.WriteLine("Total sum of numbers: " + sum);
      }
    }
  }
}
