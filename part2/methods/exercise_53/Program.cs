using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:

      Division(10, 6);
    
    }

    // Write your method here:
    public static void Division(int numerator, int denominator)
    {
      double divAnswer = (double)numerator / denominator;
      string dotAnswer = Convert.ToString(divAnswer);
      string converted = dotAnswer.Replace(",", ".").Replace(".", ".");
      Console.WriteLine(converted);
    }

  }
}
