using System;

public class Kata 
{
  public static int FindSmallestInt(int[] args) 
  {
    Array.Sort(args);
    return args[0];
  }
}