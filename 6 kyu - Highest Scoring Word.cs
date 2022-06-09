/*
Given a string of words, you need to find the highest scoring word.

Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.

You need to return the highest scoring word as a string.

If two words score the same, return the word that appears earliest in the original string.

All letters will be lowercase and all inputs will be valid.
*/

public class Kata
{
  public static string High(string s)
  {
    string[] sSplit = s.Split('\u0020');
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    int[] wordsScore = new int[sSplit.Length];
    int highScore = 0;
    int highScorePosition = 0;

    for (int i = 0; i < sSplit.Length; i++)
    {
      for (int j = 0; j < sSplit[i].Length; j++)
      {
        for (int k = 0; k < alphabet.Length; k++)
        {
          if (sSplit[i][j] == alphabet[k])
          {                            
            wordsScore[i] += k + 1;
            break;
          }
        }
      }

      if (wordsScore[i] > highScore)
      {
        highScore = wordsScore[i];
        highScorePosition = i;
      }
    }

    return sSplit[highScorePosition];
    
  }
}