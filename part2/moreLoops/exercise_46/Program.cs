using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      string userinput = Console.ReadLine();
      int input = Convert.ToInt32(userinput);

      int number = 100;

      while(input <= number)
      {
        Console.WriteLine(input);
        input = input + 1;
      }

    }
  }
}
