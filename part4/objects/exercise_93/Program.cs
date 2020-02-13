using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!

      Account nabilsAccount = new Account("Nabil's account", 100.00);
      nabilsAccount.Deposit(20.0);
      Console.WriteLine(nabilsAccount.balance);


    }
  }
}



