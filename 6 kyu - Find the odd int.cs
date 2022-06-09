/*
Given an array of integers, find the one that appears an odd number of times.

There will always be only one integer that appears an odd number of times.

Examples
[7] should return 7, because it occurs 1 time (which is odd).
[0] should return 0, because it occurs 1 time (which is odd).
[1,1,2] should return 2, because it occurs 1 time (which is odd).
[0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
*/

using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        IEnumerable<int> uniqueItems = seq.Distinct<int>();
        int[] uniques = uniqueItems.ToArray();            
        int[] occurence = new int[uniques.Length];
        int result = 0;

        for (int i = 0; i < uniques.Length; i++)
        {                
          occurence[i] = seq.Count(n => n == uniques[i]);                                
          if (occurence[i] % 2 != 0) result = uniques[i];          
        }      
        return result;
      }       
    }
}