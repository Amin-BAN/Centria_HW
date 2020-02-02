using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:'

     PrintUntilNumber(3);
 
    }

    // Write your method here:
    public static void PrintUntilNumber(int input)
    {
      int number = 1;
    while (number <= input)
    {
      Console.WriteLine(number);
      number = number + 1;
    }
     
    }

  }
}
