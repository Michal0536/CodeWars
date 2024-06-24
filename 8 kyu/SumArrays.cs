// Write a function that takes an array of numbers and returns the sum of the numbers. The numbers can be negative or non-integer. If the array does not contain any numbers then you should return 0.
using System.Collections.Generic;

public class Kata
{
  public static double SumArray(double[] array)
  {
    double suma = 0;
    foreach(double i in array){
      suma+=i;
    }
    return suma;
  }
}