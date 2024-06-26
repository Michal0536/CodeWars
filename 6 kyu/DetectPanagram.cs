// A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
// Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.

using System;
using System.Collections.Generic;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    string s = str.ToLower();
    HashSet<char> letters = new HashSet<char>();
    
    
    foreach(char c in s){
      if(c >='a' && c <= 'z'){
        letters.Add(c);
      }
    }
    
    return letters.Count == 26;
  }
}