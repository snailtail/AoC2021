using System.Text.RegularExpressions;
using System.IO;

namespace AoC2018_05
{
    class AoC201805
    {
        public static void Main(string[] args)
        {

            bool loopCondition = true;
            var regex = getRegex();
            var myRegex = new Regex(regex);

            //string input = "dabAcCaCBAcCcaDA";
            string input = File.ReadAllText("input.txt");

            while (loopCondition)
            {
                var match = myRegex.Match(input);
                //Console.WriteLine($"Found {match.Value}");
                loopCondition = match.Success;
                //how to loop
                input = myRegex.Replace(input, "", 1);
                //Console.WriteLine($"Input is now: {input}");
            }
            Console.WriteLine(input.Length);
        }

        private static string getRegex()
        {
            string originChars = "abcdefghijklmnopqrstuvwxyz";
            string regEx = string.Empty;
            foreach (char ch in originChars)
            {
                var temp = ch.ToString().ToUpper();
                regEx += $"{ch}{temp}|{temp}{ch}|";
            }
            regEx = regEx.Substring(0, regEx.Length - 1);
            regEx = $"({regEx})";
            return regEx;
        }
    }
}