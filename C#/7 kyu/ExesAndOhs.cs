// Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    input = input.ToLower();
    int xCounter =0;
    int oCounter =0;
    foreach (char c in input){
      if (c == 'x'){
        xCounter+=1;
      }
      if (c == 'o'){
        oCounter+=1;
      }
    }
    if (oCounter == xCounter){
      return true;
    }
    else{
      return false;
    }
  }
}