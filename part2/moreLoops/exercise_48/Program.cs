using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      Console.WriteLine("Give numbers:");

      int sum = 0;
      int number = 0;
      double average = 0.00;
      int even = 0;
      int odd = 0;

      while (true) 
      
      {

      string userinput = Console.ReadLine();
      int input = Convert.ToInt32(userinput);

      if (input == -1)
      {
        break;
      }

      sum = sum + input;
      number = number + 1;
      average = (double)sum / number;
      
      if ((input % 2) == 0)
      {
        even = even + 1;
      }
      else
      {
        odd = odd + 1;
      }

      }

      Console.WriteLine("Thx! " + "Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + number);
      Console.WriteLine("Average: " + average);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: "+ odd);

      
      
 
    }
  }
}
