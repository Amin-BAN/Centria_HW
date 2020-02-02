using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      string userinput = Console.ReadLine();
      int input = Convert.ToInt32(userinput);

      int number = 0;
      
      while(number <= input)
      {
        Console.WriteLine(number);
        number = number + 1;
      }

    }
  }
}
