/*
Complete the solution so that the function will break up camel casing, using a space between words.

Example
"camelCasing"  =>  "camel Casing"
"identifier"   =>  "identifier"
""             =>  ""

*/

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    string result = str;
    int index = 0;

    for (int i = 0; i < str.Length; i++)
    {
      if (string.Equals(str[i], char.ToUpper(str[i])))
      {
        result = result.Insert(i + index, " ");
        index++;
      }
    }
    return result;
  }
}