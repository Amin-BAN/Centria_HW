using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();

      Console.WriteLine("Give an integer:");
      string integar = Console.ReadLine();
      int integarValue = Convert.ToInt32(integar);

      Console.WriteLine("Give a double:");
      string userInput = Console.ReadLine();
      double doubleValue = Convert.ToDouble(userInput);

      Console.WriteLine("Give a boolean:");
      string input = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(input);

      Console.WriteLine("Your string: " + message);
      Console.WriteLine("Your integer: " + integar);
      Console.WriteLine("Your double: " + userInput);
      Console.WriteLine("Your boolean: " + input);


    }
  }
}
