/*
Return the number (count) of vowels in the given string.

We will consider a, e, i, o, u as vowels for this Kata (but not y).

The input string will only consist of lower case letters and/or spaces.

*/

using System;
using System.Linq;

public static class Kata
{
  public static int GetVowelCount(string str)
  {
    int vowelCount = 0;
    string vow = "AaEeIiOoUu";

    for (int i = 0; i < str.Length; i++)
    {
      for (int y = 0; y < vow.Length; y++)
      {
        if (str[i] == vow[y]) vowelCount++;                    
      }    
    }
  return vowelCount;
  }
}