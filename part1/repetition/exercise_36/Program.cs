using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true)
      {
        Console.WriteLine("Give a number:");
        string input = Console.ReadLine();
        int userinput = Convert.ToInt32(input);

        if (userinput == 0)
        {
          break;
        }
        else if (userinput < 0)
        {
          Console.WriteLine("That is negative");
        }
        else
        {
          Console.WriteLine(userinput * userinput);
        }

      }      

    }
  }
}
