using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      string userinput = Console.ReadLine();
      int input = Convert.ToInt32(userinput);

      string userinput1 = Console.ReadLine();
      int input1 = Convert.ToInt32(userinput1);

      int sum = input + input1;

      double squareroot = Math.Sqrt(sum);
      Console.WriteLine(squareroot);
    
    }
  }
}
