using System;
using System.IO;
using System.Linq;
namespace AoC2017_08
{
    public class Instruction
    {
        public string Register { get; private set; }
        public bool Increase  { get; private set; }
        public int Amount { get; private set; }
        public string CheckRegister  { get; private set; }

        public string CheckString  { get; private set; }
        public int CheckValue  { get; private set; }
        public Instruction(string instructionLine)
        {
            var parts = instructionLine.Split();
            Register = parts[0];
            if(parts[1]=="dec")
            {
                Increase = false;
            }
            else
            {
                Increase = true;
            }
            Amount = int.Parse(parts[2]);
            CheckRegister = parts[4];
            CheckString = parts[5];
            CheckValue = int.Parse(parts[6]);
        }

        public override string ToString()
        {
            return $"Register: {Register} Increase: {Increase} Amount: {Amount} CheckRegister: {CheckRegister} CheckString: {CheckString} CheckValue: {CheckValue}";
            //return base.ToString();
        }
    }
    public static class AoC201708
    {
        public static string[] fileReader(string path)
        {
            string[] allLines = File.ReadAllLines(path).Where(l => !string.IsNullOrEmpty(l)).ToArray();
            return allLines;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var step1 = AoC201708.fileReader("sample.txt");
            Instruction instr;
            foreach(var line in step1)
            {
                instr = new Instruction(line);
                Console.WriteLine(instr);
            }
        }
    }
}
