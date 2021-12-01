using AdventOfCode.Helpers;
using System.Linq;

namespace AdventOfCode.Y2021
{
    public static class Day01
    {
        public static int Step1(string[] lines)
        {
            int[] measurements = lines.Select(l => int.Parse(l)).ToArray();
            int counter = 0;
            for (int n = 0; n < measurements.Length; n++)
            {
                if (n + 1 < measurements.Length)
                {
                    if (measurements[n + 1] > measurements[n])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static int Step2(string[] lines)
        {
            int[] measurements = lines.Select(l => int.Parse(l)).ToArray();
            int counter = 0;
            int lastsum = 0;
            for (int n = 0; n < measurements.Length - 2; n++)
            {
                if (n > 0)
                {
                    if ((measurements[n] + measurements[n + 1] + measurements[n + 2]) > lastsum)
                    {
                        counter++;
                    }
                }
                lastsum = (measurements[n] + measurements[n + 1] + measurements[n + 2]);
            }
            return counter;
        }
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            Console.WriteLine(Step1(lines));
            Console.WriteLine(Step2(lines));
        }
    }
}

