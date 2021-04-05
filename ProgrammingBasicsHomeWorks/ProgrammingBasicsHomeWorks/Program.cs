using System;

namespace ProgrammingBasicsHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool exit = false;
                string exitWord = "exit";
                string userInput = "";

                while (!exit)
                {
                    Console.WriteLine("Write \"Exit\" to end this loop.");
                    userInput = Console.ReadLine();

                    if(userInput.ToLower() == exitWord)
                        break;
                    else
                        Console.WriteLine($"\"{userInput}\" is not \"Exit\". Try again.");
                }
            }
        }
    }
}
