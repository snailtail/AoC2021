using System;

public class StringHelper
{
    /// <summary>
    /// Takes a string, sorts the chars within the string as chars, returns them as a string.
    /// </summary>
    /// <param name="inputString">The input string</param>
    /// <returns>A string containing the characters from the input, sorted in order as characters.</returns>
    public string sortedString(string inputString)
    {
        char[] charArray = inputString.ToCharArray();
        Array.Sort<char>(charArray);
        return new string(charArray);
    }
}