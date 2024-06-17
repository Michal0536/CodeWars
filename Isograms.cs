// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

using System;
using System.Collections.Generic;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    List<char> literki = new List<char>();
    foreach(char letter in str.ToLower()){
      if (literki.Contains(letter)){
        return false;
      }
      else{
      literki.Add(letter);
      }
    }
    return true;
    
  }
}