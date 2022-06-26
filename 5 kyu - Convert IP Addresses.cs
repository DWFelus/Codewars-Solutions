/*
Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).

All inputs will be valid IPv4 addresses in the form of strings. The last address will always be greater than the first one.

Examples

* With input "10.0.0.0", "10.0.0.50"  => return   50 
* With input "10.0.0.0", "10.0.1.0"   => return  256 
* With input "20.0.0.10", "20.0.1.0"  => return  246

*/

using System;
using System.Collections.Generic;
using System.Linq;
public class CountIPAddresses
{
  public static long IpsBetween(string start, string end)
  {
    List<string> s = start.Split('.').ToList();
    s.Reverse();

    List<string> e = end.Split('.').ToList();
    e.Reverse();

    List<long> diff = new List<long>();

    for (int i = 0; i < s.Count; i++)
    {
      diff.Add(int.Parse(e[i]) - int.Parse(s[i]));

      double pow;
      pow = Math.Pow(256, i);
      diff[i] = (long)(pow * diff[i]);
    }

    return diff.Sum();
  }
}