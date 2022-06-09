/*
An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

Example: (Input --> Output)

"Dermatoglyphics" --> true
"aba" --> false
"moOse" --> false (ignore letter case)
*/

using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    char[] strChar = str.ToCharArray();
    bool isIsogram = true;
    for (int i = 0; i < str.Length; i++)
      {
        int sameLetterCount = 0;
        if (!isIsogram) break;
        for (int y = 0; y < str.Length; y++)
        {
          if (strChar[i].Equals(Char.ToUpper(strChar[y])) || strChar[i] == strChar[y])
          {
            sameLetterCount++;
          }
          if (sameLetterCount > 1)
          {
            isIsogram = false;
            break;
          }
        }
      }
    return isIsogram;
  }
}