/*
You get an array of numbers, return the sum of all of the positives ones.

Example [1,-4,7,12] => 1 + 7 + 12 = 20

Note: if there is nothing to sum, the sum is default to 0.
*/

using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int[] posArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] >= 0)
      {
        posArr[i] = arr[i];
      }
    }

    int sum = posArr.Sum();
    return sum; 
  }
}