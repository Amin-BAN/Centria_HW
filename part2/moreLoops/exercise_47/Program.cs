using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      Console.WriteLine("Where to?");
      string userinput = Console.ReadLine();
      int input = Convert.ToInt32(userinput);

      Console.WriteLine("Where from?");
      string userinput2 = Console.ReadLine();
      int input2 = Convert.ToInt32(userinput2);

      int count = input2;

      while (count <= input)
      {
        Console.WriteLine(count);
        count = count + 1;
      }
      
    }
  }
}
