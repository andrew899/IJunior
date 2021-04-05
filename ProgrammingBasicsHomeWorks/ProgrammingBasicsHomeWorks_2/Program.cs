using System;

namespace ProgrammingBasicsHomeWorks_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userText = "";
            int amountOfRepeat = 0;

            Console.Write("Write your text: ");
            userText = Console.ReadLine();
            
            Console.Write("How many times repeat: ");
            amountOfRepeat = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfRepeat; i++)
            {
                Console.WriteLine(i + ". " + userText);
            }
        }
    }
}
