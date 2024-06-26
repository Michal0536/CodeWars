// In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      List<int> ListOfInts = new List<int>();
     
      foreach(object x in listOfItems){
        if (x is int){
          ListOfInts.Add((int)x);
        }
      }
     return ListOfInts;
   }
}
