namespace AdventOfCode
{
    public static class Day06
    {
        private static Dictionary<int, long> fishAgeGroups = new();
        public static void Main(string[] args)
        {
            //step 1
            resetFishAgeGroups();
            for (int i = 0; i < 80; i++)
            {
                AgeFish();
            }
            long sumStep1 = 0;
            foreach (KeyValuePair<int, long> kv in fishAgeGroups)
            {
                sumStep1 += kv.Value;
            }
            Console.WriteLine(sumStep1);

            //Step 2, reset and do over
            resetFishAgeGroups();
            for (int i = 0; i < 256; i++)
            {
                AgeFish();
            }
            long sumStep2 = 0;
            foreach (KeyValuePair<int, long> kv in fishAgeGroups)
            {
                sumStep2 += kv.Value;
            }
            Console.WriteLine(sumStep2);

        }

        public static void AgeFish()
        {
            long new8 = fishAgeGroups[0];
            long add6 = fishAgeGroups[0];
            long new0 = fishAgeGroups[1];
            long new1 = fishAgeGroups[2];
            long new2 = fishAgeGroups[3];
            long new3 = fishAgeGroups[4];
            long new4 = fishAgeGroups[5];
            long new5 = fishAgeGroups[6];
            long new6 = fishAgeGroups[7] + add6;
            long new7 = fishAgeGroups[8];

            fishAgeGroups[0] = new0;
            fishAgeGroups[1] = new1;
            fishAgeGroups[2] = new2;
            fishAgeGroups[3] = new3;
            fishAgeGroups[4] = new4;
            fishAgeGroups[5] = new5;
            fishAgeGroups[6] = new6;
            fishAgeGroups[7] = new7;
            fishAgeGroups[8] = new8;

        }

        private static void resetFishAgeGroups()
        {
            fishAgeGroups.Clear();
            for (int i = 0; i < 9; i++)
            {
                fishAgeGroups.Add(i, 0);
            }
            int[] fishes = File.ReadAllText("input.txt").Split(',').Select(f => int.Parse(f)).ToArray();
            // add the initial fishes states
            foreach (var i in fishes)
            {

                fishAgeGroups[i]++;
            }
        }
    }


}