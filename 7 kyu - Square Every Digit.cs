/*
Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

Note: The function accepts an integer and returns an integer
*/

using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string nString = n.ToString();
    string result = null;
    int[] nInt = new int[nString.Length];

    for (int i = 0; i < nInt.Length; i++)
    {
      nInt[i] = int.Parse(nString.Substring(i, 1)) * int.Parse(nString.Substring(i, 1));
      result += nInt[i];
    }
    return int.Parse(result);
  }
}