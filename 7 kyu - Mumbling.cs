/*
This time no story, no theory. The examples below show you how to write function accum:

Examples:
accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.

*/


using System;

public class Accumul 
{
  public static String Accum(string s) 
  {
    s = s.ToLower();
    string result = "";
    int[] sIndex = new int[s.Length];

    for (int i = 0; i < s.Length; i++)
    {
      sIndex[i] = i + 1;
      bool firstLetter = true;
      for (int j = 0; j < sIndex[i]; j++)
      {
        if (firstLetter == true)
        {
          result += s[i].ToString().ToUpper();
          firstLetter = false;
        }

        else
        {
          result += s[i];
        }

      }
      if (i != s.Length - 1) result += "-";
    }

    return result;
  }
}