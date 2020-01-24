using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {
      int number = 120;

      Console.WriteLine("Your speed:");

      string value = Console.ReadLine();

      int inputValue = Convert.ToInt32(value);

      if (inputValue > number)

      {
        Console.WriteLine("Speeding!");
      }



      // Write your code here:
      
    }
  }
}
