using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information." + "\n" + "Give a name for main character:");
            String input_Name = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            String input_Profession = Console.ReadLine();
           Console.WriteLine("Here is the story:" + "\n" + "Once upon a time there was a " + input_Profession + " called " + input_Name + "\n" + "On her way to work, " + input_Name + " often pondered what being " + input_Profession + " meant to them." + "\n" + "When you work as a " + input_Profession + " you meet interesting people." + "\n" + input_Name + " enjoys their work as " + input_Profession + "," + " The end.");

        }
    }
}
