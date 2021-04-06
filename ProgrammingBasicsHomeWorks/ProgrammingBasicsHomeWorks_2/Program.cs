using System;

namespace ProgrammingBasicsHomeWorks_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int walletUSD = 1000;
            int walletEUR = 1000;
            int walletRUS = 1000;

            int convertCostUSDToRUS = 60;
            int convertCostEURToRUS = 80;
            int convertCostRUSToUSD = 70;
            int convertCostRUSToEUR = 90;

            int sumToConvert = 0;

            bool exit = false;
            while (!exit)
            {
                int menuItem = 0;

                Console.WriteLine($"Your balance: \n USD : {walletUSD} \n EUR : {walletEUR} \n RUS : {walletRUS}");
                Console.WriteLine("1. Conwert USD to RUS.");
                Console.WriteLine("2. Conwert EUR to RUS.");
                Console.WriteLine("3. Conwert RUS to USD.");
                Console.WriteLine("4. Conwert RUS to EUR.");
                Console.WriteLine("5. Exit");
                
                menuItem = Int32.Parse(Console.ReadLine());

                switch (menuItem)
                {
                    case 1:
                        {
                            Console.Write("How much USD to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            walletUSD -= sumToConvert;
                            walletRUS = sumToConvert * convertCostUSDToRUS;
                            break;
                        }
                    case 2:
                        {
                            Console.Write("How much EUR to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            walletEUR -= sumToConvert;
                            walletRUS = sumToConvert * convertCostEURToRUS;
                            break;
                        }
                    case 3:
                        {
                            Console.Write("How much RUS to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            walletRUS -= sumToConvert;
                            walletUSD = sumToConvert / convertCostRUSToUSD;
                            walletRUS += sumToConvert % convertCostRUSToUSD;
                            break;
                        }
                    case 4:
                        {
                            Console.Write("How much RUS to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            walletRUS -= sumToConvert;
                            walletEUR = sumToConvert / convertCostRUSToEUR;
                            walletRUS += sumToConvert % convertCostRUSToEUR;
                            break;
                        }
                    case 5: 
                        {
                            exit = true;
                            break; 
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input. Try againe.");
                            break;
                        }
                        
                }
            }
        }
    }
}
