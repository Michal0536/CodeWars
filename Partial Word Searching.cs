// Write a method that will search an array of strings for all strings that contain another string, ignoring capitalization. Then return an array of the found strings.
// The method takes two parameters, the query string and the array of strings to search, and returns an array.
// If the string isn't contained in any of the strings in the array, the method returns an array containing a single string: "Empty" (or Nothing in Haskell, or "None" in Python and C)
// Examples
// If the string to search for is "me", and the array to search is ["home", "milk", "Mercury", "fish"], the method should return ["home", "Mercury"].

using System;
using System.Collections.Generic;

public class Kata
{
    public static string[] WordSearch(string query, string[] seq)
    {
        List<string> foundWords = new List<string>();

        foreach (string word in seq)
        {
            if (word.ToLower().Contains(query.ToLower()))
            {
                foundWords.Add(word);
            }
        }

        if (foundWords.Count == 0)
        {
            return new string[] { "Empty" };
        }
        else
        {
            return foundWords.ToArray();
        }
    }
}
