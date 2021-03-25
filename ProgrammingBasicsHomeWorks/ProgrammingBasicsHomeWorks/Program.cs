using System;

namespace ProgrammingBasicsHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int timeInLine = 10;
                int amountPeopleInLine = 0;

                int fullWaiteTime = 0;
                int hoursToWaite = 0;
                int minutesToWaite = 0;

                Console.Write("How many people in line: ");
                amountPeopleInLine = Int32.Parse(Console.ReadLine());

                fullWaiteTime = timeInLine * amountPeopleInLine;
                hoursToWaite = fullWaiteTime / 60;
                minutesToWaite = fullWaiteTime % 60;

                Console.WriteLine($"Wait for {hoursToWaite} hour(s) and {minutesToWaite} minute(s)");
            }
        }
    }
}
