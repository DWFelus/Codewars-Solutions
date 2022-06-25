/*

Complete the function/method so that it takes a PascalCase string and returns the string in snake_case notation. Lowercase characters can be numbers. If the method gets a number as input, it should return a string.
Examples

"TestController"  -->  "test_controller"
"MoviesAndBooks"  -->  "movies_and_books"
"App7Test"        -->  "app7_test"
1                 -->  "1"

*/

using System;
using System.Linq;

public static class Kata 
{
  public static string ToUnderscore(int str)
  {
    return Convert(str.ToString());
  }

  public static string ToUnderscore(string str)
  {
    return Convert(str);
  }

  public static string Convert(string input)
  {
    var result = string.Concat(input.Select(c => char.IsUpper(c)
    ? "_" + c.ToString() : c.ToString()))
    .ToLower();

    if (result[0] == '_')
    {
      result = result.Remove(0, 1);
    }

    return result;
  }
}