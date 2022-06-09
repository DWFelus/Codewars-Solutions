/*
In this example you have to validate if a user input string is alphanumeric. The given string is not nil/null/NULL/None, so you don't have to check that.

The string has the following conditions to be alphanumeric:

At least one character ("" is not valid)
Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
No whitespaces / underscore
*/

using System.Text.RegularExpressions;
public class Kata
{
  public static bool Alphanumeric(string str)
  {
    bool result = true;

    if (str == "") return false;

    for (int i = 0; i < str.Length; i++)
    {
      bool positive = false;
      if (Regex.IsMatch(str[i].ToString(), @"[a-zA-Z0-9]"))
      {
          positive = true;
      }

      if (!positive)
      {
          result = false;
          break;
      }
    }
    return result;
       
  }         
}