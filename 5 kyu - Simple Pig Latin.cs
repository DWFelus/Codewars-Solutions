/*
Description:

Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
Examples

Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !

*/


using System;
using System.Linq;

public class Kata
{
  public static string PigIt(string str)
  {
    string[] s = str.Split(' '); //split str

    for (int i = 0; i < s.Length; i++)
    {
      if (s[i].Length > 1) // changing string to pig latin
      {
        s[i] += s[i].First() + "ay"; 
        s[i] = s[i].Remove(0, 1);
      }
    }
    return String.Join(" ", s);
  }
}