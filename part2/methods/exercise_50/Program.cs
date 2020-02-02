using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?");
      string userinput = Console.ReadLine();
      int input = Convert.ToInt32(userinput);

      for (int number = 0; number < input; number = number + 1)
      {
        PrintPhrase();
      }
 
    }

    // Write your method here:
    public static void PrintPhrase() 
    {

      Console.WriteLine("In a hole in the ground there lived a method");

    }
  }
}
