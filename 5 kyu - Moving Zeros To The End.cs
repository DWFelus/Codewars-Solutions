/*
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

moveZeros([false,1,0,1,2,0,1,3,"a"]) // returns[false,1,1,2,1,3,"a",0,0]
*/

using System.Collections.Generic;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    List<int> result = new List<int>();
    int zeroCount = 0;

    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] == 0)
      {
        zeroCount++;
      }
      else
      {
        result.Add(arr[i]);
      }
    }

    for (int i = 0; i < zeroCount; i++)
    {
      result.Add(0);
    }

    return result.ToArray();
  }
}