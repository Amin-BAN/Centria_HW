using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {
      int second = 60 * 60 * 24;
      Console.WriteLine("How many days?");
      string day_count = Console.ReadLine();
      int input_Value = Convert.ToInt32(day_count);
      Console.WriteLine(second * input_Value);

      // Write your code here:

    }
  }
}
