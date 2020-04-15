using System;
using Pets;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Dog doggie = new Dog();
      Cat cattie = new Cat();
      Bird birddie = new Bird();
      Man Mannie = new Man(); 
      
      Console.WriteLine(doggie.TalkToOwner());
      Console.WriteLine(cattie.TalkToOwner());
      Console.WriteLine(birddie.TalkToOwner());
      Console.WriteLine(Mannie.TalkToOwner());
    }
  }
}
