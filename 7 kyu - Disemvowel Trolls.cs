/*
Trolls are attacking your comment section!

A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

Your task is to write a function that takes a string and return a new string with all vowels removed.

For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

Note: for this kata y isn't considered a vowel.
*/

using System;

public static class Kata
{
  public static string Disemvowel(string str)
  {
    string vowels = "AaEeIiOoUu";

      for (int i = 0; i < str.Length; i++)
      {
        for (int y = 0; y < vowels.Length; y++)
        {
          if (str[i] == vowels[y])
          {
            str = str.Remove(i, 1);                        
            i--;
          }
        }               
      }           
    
    return str;
  }
}