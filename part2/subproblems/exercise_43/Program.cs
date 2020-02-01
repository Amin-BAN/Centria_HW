using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
     
      string userinput = Console.ReadLine();
      int input = Convert.ToInt32(userinput);

      if (input < 0)
      {
        Console.WriteLine(input * -1);
      }
      else
      {
        Console.WriteLine(input);
      }
      
    }
  }
}
