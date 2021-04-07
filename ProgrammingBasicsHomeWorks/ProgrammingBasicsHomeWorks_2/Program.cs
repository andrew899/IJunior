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

            int convertCostUSDToRUS = 10;
            int convertCostUSDToEUR = 20;
            int convertCostEURToRUS = 30;
            
            int sumToConvert = 0;

            bool exit = false;
            while (!exit)
            {
                int menuItem = 0;

                Console.WriteLine($"Your balance: \n USD : {walletUSD} \n EUR : {walletEUR} \n RUS : {walletRUS}");
                Console.WriteLine("1. Conwert USD to RUS.");
                Console.WriteLine("2. Conwert USD to EUR.");
                Console.WriteLine("3. Conwert EUR to RUS.");
                Console.WriteLine("4. Conwert EUR to USD."); // to do
                Console.WriteLine("5. Conwert RUS to USD.");
                Console.WriteLine("6. Conwert RUS to EUR.");
                Console.WriteLine("7. Exit");

                menuItem = Int32.Parse(Console.ReadLine());

                switch (menuItem)
                {
                    case 1:
                        {
                            Console.Write("How much USD to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            if (sumToConvert > walletUSD)
                            {
                                Console.WriteLine($"You do not have {sumToConvert} USD in your wallet.");
                                break;
                            }
                            walletUSD -= sumToConvert;
                            walletRUS += sumToConvert * convertCostUSDToRUS;
                            break;
                        }
                    case 2:
                        {
                            Console.Write("How much USD to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            if (sumToConvert > walletUSD)
                            {
                                Console.WriteLine($"You do not have {sumToConvert} USD in your wallet.");
                                break;
                            }
                            walletUSD -= sumToConvert;
                            walletEUR += sumToConvert * convertCostUSDToEUR;
                            break;
                        }
                    case 3:
                        {
                            Console.Write("How much EUR to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            if (sumToConvert > walletEUR)
                            {
                                Console.WriteLine($"You do not have {sumToConvert} EUR in your wallet.");
                                break;
                            }
                            walletEUR -= sumToConvert;
                            walletRUS += sumToConvert * convertCostEURToRUS;
                            break;
                        }
                    case 4:
                        {
                            Console.Write("How much EUR to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            if (sumToConvert > walletEUR)
                            {
                                Console.WriteLine($"You do not have {sumToConvert} EUR in your wallet.");
                                break;
                            }
                            walletEUR -= sumToConvert;
                            walletUSD += sumToConvert * convertCostUSDToEUR;
                            break;
                        }
                    case 5:
                        {
                            Console.Write("How much RUS to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            if (sumToConvert > walletRUS)
                            {
                                Console.WriteLine($"You do not have {sumToConvert} RUS in your wallet.");
                                break;
                            }
                            walletRUS -= sumToConvert;
                            walletUSD += sumToConvert * convertCostUSDToRUS;
                            break;
                        }
                    case 6:
                        {
                            Console.Write("How much RUS to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());
                            if (sumToConvert > walletRUS)
                            {
                                Console.WriteLine($"You do not have {sumToConvert} RUS in your wallet.");
                                break;
                            }
                            walletRUS -= sumToConvert;
                            walletEUR += sumToConvert * convertCostEURToRUS;
                            break;
                        }
                    case 7:
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
