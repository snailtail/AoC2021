using System;
using System.IO;

namespace AoC2017_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] programList = File.ReadAllLines("input.txt");
            AoC201707 myProcessor = new AoC201707();
            string step1 = myProcessor.getBottomProgram(programList);
            Console.WriteLine($"Step 1: {step1}");

            // Step 2 - Probably move towards custom type for storing the programs, and LINQ to fetch relations.
            // Needs to be some sort of a recursive loop until no more children are found - async? or parallell processing perhaps?
        }
    }
}
