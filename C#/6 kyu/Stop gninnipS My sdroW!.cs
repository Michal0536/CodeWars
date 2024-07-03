// Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    string[] words = sentence.Split(' ');
    for(int i=0; i<words.Length;i++){
      if (words[i].Length >= 5){
        char[] charArray = words[i].ToCharArray();
        Array.Reverse(charArray);
        words[i] = new string(charArray);
        
      }
    }
    return string.Join(" ",words);
  }
}