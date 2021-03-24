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

                int demandToBuy = 0;
                int fullPrice = 0;

                Console.WriteLine("Welcom to our shop!");
                Console.WriteLine($"One crystal costs: {priceCrystal}");
                Console.Write("How much money do you have? ");
                playerMoney =  Int32.Parse(Console.ReadLine());

                Console.Write("How many crystals do you want to buy? ");
                demandToBuy =  Int32.Parse(Console.ReadLine());

                fullPrice = demandToBuy * priceCrystal;
                playerMoney = playerMoney - fullPrice;

                Console.WriteLine($"You bought: {demandToBuy}.");
                Console.WriteLine($"Money left: {playerMoney}.");
            }
        }
    }
}
