// Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.
// Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case

using System;

public class Kata
{
  public static int CountBits(int n)
  {
    
    string binary = Convert.ToString(n,2);
    int counter = 0;
    
    for (int i=0; i<binary.Length; i++){
        if (binary[i] == '1'){
          counter++;
        } 
    }    
    return counter;
  }
}