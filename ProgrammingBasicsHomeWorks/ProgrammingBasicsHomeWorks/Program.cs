using System;

namespace ProgrammingBasicsHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string name;
                string surname;

                int age;
                string zodiacSign;
                string workplace;

                Console.Write("What are your name: ");
                name = Console.ReadLine();

                Console.Write("What are your surname: ");
                surname = Console.ReadLine();

                Console.Write("What are your age: ");
                age = Int32.Parse(Console.ReadLine());

                Console.Write("What are your zodiac: ");
                zodiacSign = Console.ReadLine();

                Console.Write("Where do you work: ");
                workplace = Console.ReadLine();

                Console.Write($"Your name is {surname} {name}. \n" +
                    $"You are {age} years old. \n" +
                    $"You are {zodiacSign} and you work at {workplace}.");
            }
        }
    }
}
