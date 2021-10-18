using System.Collections.Generic;

namespace AoC2017_07
{
    public class AoC201707
    {
        /// <summary>
        /// For step 1, simple and dirty solution - 
        /// not keeping anything more than we need.
        /// The actual relationships are not interesting, just need to find which program has no parent.
        /// </summary>
        /// <param name="input">Array of strings (the lines from the input file)</param>
        /// <returns>String with name of the "bottom" program - the one with no parents (it's Batman!)</returns>
        public string getBottomProgram(string[] input)
        {
            Dictionary<string, int> programList = new Dictionary<string, int>();
            foreach (string row in input)
            {
                string[] parts = row.Split(" -> ");
                string name = parts[0].Split()[0];
                if (!programList.ContainsKey(name))
                {
                    programList.Add(name, 0);
                }
                if (parts.Length > 1)
                {
                    string[] refNames = parts[1].Split(", ");
                    foreach (string refname in refNames)
                    {
                        if (!programList.ContainsKey(refname))
                        {
                            programList.Add(refname, 1);
                        }
                        else
                        {
                            programList[refname]++;
                        }
                    }
                }
            }
            foreach(KeyValuePair<string,int> kvp in programList)
            {
                if(kvp.Value==0)
                {
                    return kvp.Key;
                }
            }
            return "";
        }
    }
}
