using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your percent [0 - 100]:");
      string input = Console.ReadLine();
      int value = Convert.ToInt32(input);

      if (value < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (value <= 49)
      {
        Console.WriteLine("Fail");
      }
      else if (value <= 59)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (value <= 69)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (value <= 79)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (value <= 89)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (value <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      else 
      {
        Console.WriteLine("Outstanding!");
      }


      // Write your code here:

    }
  }
}
