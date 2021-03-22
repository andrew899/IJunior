using System;

namespace ProgrammingBasicsHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Random random = new Random();

                int playerMoney = 0;
                int priceCrystal = random.Next(1, 101);

                int boughtCrystal = 0;

                Console.WriteLine("Welcom to our shop!");
                Console.WriteLine($"One crystal costs: {priceCrystal}");
                Console.Write("How much money do you have? ");
                playerMoney =  Int32.Parse(Console.ReadLine());

                boughtCrystal = playerMoney / priceCrystal;
                playerMoney = playerMoney % priceCrystal;

                Console.WriteLine($"You bought: {boughtCrystal}.");
                Console.WriteLine($"Money left: {playerMoney}.");
            }
        }
    }
}
