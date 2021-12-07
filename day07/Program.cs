namespace AdventOfCode
{
    public static class Day07
    {
        public static void Main(string[] args)
        {
            int[] crabPositions = File.ReadAllText("input.txt").Split(",").Select(p => int.Parse(p)).ToArray();
            crabGroup myCrabs = new crabGroup(crabPositions);
            Console.WriteLine(myCrabs);
            (int position, int fuelcost) = myCrabs.getBestPosition();
            Console.WriteLine($"Best position: {position}, fuelcost: {fuelcost}");
        }
    }

    public class Crab
    {
        public int Position { get; set; }
        public Crab(int position)
        {
            Position = position;
        }
    }
    public class crabGroup
    {
        public IEnumerable<Crab> Crabs { get; set; }

        public crabGroup(int[] crabPositions)
        {
            Crabs = crabPositions.Select(c => new Crab(c)).ToArray();
        }
        public (int, int) getBestPosition()
        {
            int thisPosition = 0;
            int fuelCost = int.MaxValue;
            int bestPosition = 0;
            foreach (var crab in Crabs)
            {
                int loopFuelCost = 0;
                thisPosition = crab.Position;
                foreach (var innerCrab in Crabs)
                {
                    loopFuelCost += Math.Abs(innerCrab.Position - thisPosition);
                }
                if (loopFuelCost < fuelCost)
                {
                    bestPosition = thisPosition;
                    fuelCost=loopFuelCost;
                }
            }
            return (bestPosition,fuelCost);
        }



        public override string ToString()
        {
            string crabData = string.Empty;
            foreach (var crab in Crabs)
            {
                crabData += $"{crab.Position}, ";
            }
            return crabData;

        }
    }
}