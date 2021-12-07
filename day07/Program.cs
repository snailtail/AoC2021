namespace AdventOfCode
{
    public static class Day07
    {
        public static void Main(string[] args)
        {
            int[] crabPositions = File.ReadAllText("input.txt").Split(",").Select(p => int.Parse(p)).ToArray();
            crabGroup myCrabs = new crabGroup(crabPositions);
            Console.WriteLine(myCrabs);
            (int position, long fuelcost) = myCrabs.getBestPosition();
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
        public int[] Crabs { get; set; }

        public crabGroup(int[] crabPositions)
        {
            Crabs = crabPositions;
        }
        private int fuelConsumption(int distance)
        {
            int fuelConsumption=0;
            for(int y = 1; y <=distance; y++)
            {
                fuelConsumption+=y;
            }
            return fuelConsumption;
        }
        public (int, long) getBestPosition()
        {
            int thisPosition = 0;
            long fuelCost = long.MaxValue;
            int bestPosition = 0;
            int maxPosition = Crabs.Max();
            int minPosition = Crabs.Min();
            
            for(int x = minPosition; x<=maxPosition; x++)
            {
                long loopFuelCost = 0;
                thisPosition = x;
                foreach (var crab in Crabs)
                {
                    loopFuelCost += fuelConsumption(Math.Abs(x - crab));
                }
                if (loopFuelCost < fuelCost)
                {
                    bestPosition = thisPosition;
                    fuelCost = loopFuelCost;
                }
            }
            return (bestPosition, fuelCost);
        }



        public override string ToString()
        {
            string crabData = string.Empty;
            foreach (var crab in Crabs)
            {
                crabData += $"{crab}, ";
            }
            return crabData;

        }
    }
}