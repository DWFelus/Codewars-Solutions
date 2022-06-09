/*
John has invited some friends. His list is:

s = "Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
Could you make a program that

makes this string uppercase
gives it sorted in alphabetical order by last name.
When the last names are the same, sort them by first name. Last name and first name of a guest come in the result between parentheses separated by a comma.

So the result of function meeting(s) will be:

"(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)"
It can happen that in two distinct families with the same family name two people have the same first name too.

Notes
You can see another examples in the "Sample tests".
*/

using System;
using System.Linq;

public class JohnMeeting
{
  public static string Meeting(string s) {
    
    int numberOfFriends = 0;

      for (int i = 0; i < s.Length; i++)
      {
        if (s[i] == ':')
        { numberOfFriends++; }
      }

      string[] full = s.Split(';');
      string[] first = new string[numberOfFriends];
      string[] last = new string[numberOfFriends];
      string[] namesForm = new string[numberOfFriends];

      for (int i = 0; i < full.Length; i++)
      {
        first[i] = full[i].Remove
        (full[i].IndexOf(":"),
          full[i].Length - full[i].IndexOf(":"));
        last[i] = full[i].Remove(0, full[i].IndexOf(":")+1);
        namesForm[i] = "(" + last[i] + ", " + first[i] + ")";
      }

      Array.Sort(namesForm);
      string sConcat = "";

      for (int i = 0; i < numberOfFriends; i++)
      {
        sConcat += namesForm[i];
      }
    
    return sConcat.ToUpper();
  }
}