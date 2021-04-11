using System;

namespace ProgrammingBasicsHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "Alexey";
            char symbol = '%';

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            Console.Write("Enter your symbol: ");
            symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string borderLine = $"{symbol}" + $"{symbol}" + new string(symbol, userInput.Length) + $"{symbol}" + $"{symbol}";
            string userInputLine = $"{symbol}" + " " + userInput + " " + $"{symbol}";

            Console.WriteLine(borderLine);
            Console.WriteLine(userInputLine);
            Console.WriteLine(borderLine);
        }
    }
}
