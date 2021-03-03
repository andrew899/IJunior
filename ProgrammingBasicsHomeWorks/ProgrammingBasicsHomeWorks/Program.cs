using System;

namespace ProgrammingBasicsHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int picturesAmount = 52;
                int rowSize = 3;

                int fullRows = picturesAmount / rowSize; 
                int lastRow = picturesAmount % rowSize;
                
                Console.WriteLine($"Рядов заполненых картинками: {picturesAmount}.");
                Console.WriteLine($"Каартинок в неполном ряде: {lastRow}.");
            }
        }
    }
}
