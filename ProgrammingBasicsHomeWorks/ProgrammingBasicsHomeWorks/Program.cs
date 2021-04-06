using System;

namespace ProgrammingBasicsHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Vasia";
            string password = "root";

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Set Name.");
                Console.WriteLine("2. Set Password.");
                Console.WriteLine("3. Get Name (need password).");
                Console.WriteLine("4. Change Console Color.");
                Console.WriteLine("5. Exit.");

                int menuItem = Int32.Parse(Console.ReadLine());

                switch (menuItem)
                {
                    case 1:
                        {
                            Console.Write("What is your name: ");
                            name = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("What is your password: ");
                            password = Console.ReadLine().ToLower();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Password: ");
                            string passInput = Console.ReadLine().ToLower();
                            if (passInput == password)
                                Console.WriteLine($"Your name is {name}");
                            else
                                Console.WriteLine("Wrong password!!!");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("1. Set Red.");
                            Console.WriteLine("2. Set Green.");
                            Console.WriteLine("3. Set Yellow.");
                            Console.WriteLine("4. Set Magenta.");
                            Console.WriteLine("5. Reset default.");

                            int menuItemConsoleColor = Int32.Parse(Console.ReadLine());

                            switch (menuItemConsoleColor)
                            {
                                case 1:
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.BackgroundColor = ConsoleColor.Green;
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.BackgroundColor = ConsoleColor.Magenta;
                                        break;
                                    }

                                case 5:
                                    {
                                        Console.ResetColor();
                                        break;
                                    }

                                default:
                                    {
                                        Console.WriteLine("Wrong input. Try again.");
                                        break;
                                    }
                            }
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
