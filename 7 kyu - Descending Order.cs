/*
Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

Examples:
Input: 42145 Output: 54421

Input: 145263 Output: 654321

Input: 123456789 Output: 987654321
*/

using System;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    string numString = num.ToString();
    int[] numArray = new int[numString.Length];
      for (int i = 0; i < numArray.Length; i++)
       {
         numArray[i] = int.Parse(numString[i].ToString());
       }
       
    Array.Sort(numArray);
    Array.Reverse(numArray);
    string numArrayReversed = "";

    for (int i = 0; i < numArray.Length; i++)
      {
        numArrayReversed = numArrayReversed.Insert(i, numArray[i].ToString());
      }

    int numReversed = int.Parse(numArrayReversed);     
    return numReversed;  
  }
}