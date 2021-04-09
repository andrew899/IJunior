using System;

namespace ProgrammingBasicsHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Alexey";
            char symbol = '%';

            Console.Write("Enter your string: ");
            name = Console.ReadLine();

            Console.Write("Enter your symbol: ");
            symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int leftborder = 1;
            int rightborder = 1;
            int leftPadinng = 1;
            int rightPadinng = 1;

            int lineAmount = 3;
            int lineLenth = leftborder + leftPadinng + name.Length + rightPadinng + rightborder;

            for (int i = 0; i < lineAmount; i++)
            {
                for (int j = 0; j < lineLenth; j++)
                {
                    if (i == 0 || i == (lineAmount - 1))
                        Console.Write(symbol);
                    else if (j < rightborder || j == lineLenth - 1)
                        Console.Write(symbol);
                    else if (j == leftborder + leftPadinng)
                    {
                        Console.Write(name);
                        j += name.Length - 1;
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
