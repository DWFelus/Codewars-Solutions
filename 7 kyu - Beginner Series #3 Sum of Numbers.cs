/*
Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.

Note: a and b are not ordered!

Examples (a, b) --> output (explanation)
(1, 0) --> 1 (1 + 0 = 1)
(1, 2) --> 3 (1 + 2 = 3)
(0, 1) --> 1 (0 + 1 = 1)
(1, 1) --> 1 (1 since both are same)
(-1, 0) --> -1 (-1 + 0 = -1)
(-1, 2) --> 2 (-1 + 0 + 1 + 2 = 2)
*/

  
using System;
using System.Linq;
using System.Collections.Generic;
public class Sum
{
  public int GetSum(int a, int b)
  {
    int[] sort = { a, b };
    Array.Sort(sort);

    List<int> myList = new List<int>();
    
    for (int i = 0;; i++)
    {
      myList.Add(sort[0] + i); 
      if (myList.Last()==sort[1]) 
        break;
    }
    
    return myList.Sum();

  }
}