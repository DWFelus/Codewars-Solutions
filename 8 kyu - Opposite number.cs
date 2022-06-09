using System;

public class Kata
{
  public  static int Opposite(int number)
  {
  int invNum;
    if (number >= 0) invNum = number - (number * 2);
    else invNum = Math.Abs(number);
    return invNum;
  }
}