using System;

public class Kata
{
    public static string Remove_char(string s)
    {
      s = s.Remove(s.Length-1, 1);
      s = s.Remove(0, 1);
      return s;
    }
}