using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int amount = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        string userinput = Console.ReadLine();
        int input = Convert.ToInt32(userinput);

        if (input == 0)
        {
          break;
        }
        else 
        {
          amount = amount + 1;
          sum = sum + input;
        }  
      }
         {
          Console.WriteLine("Total sum of numbers: " + sum);
          Console.WriteLine("Total amount of numbers: " + amount);
         }
    }
  }
}  

