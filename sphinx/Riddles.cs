using System;
using System.Collections.Generic;
using System.Linq;

namespace Sphinx.Riddles
{
  public class Riddle
  {
    private string _riddle;
    private string _answer;
    private static int _riddleIndex;

    public static List<string> riddles = new List<string>{};
    public  static List<string> answers = new List<string>{};
    public Riddle(string riddle, string answer)
    {
      _riddle = riddle;
      _answer = answer;
      riddles.Add(_riddle);
      answers.Add(_answer);
    }
    public static string AskRiddle()
    {
      Random rand = new Random();
      _riddleIndex = rand.Next(riddles.Count);
      return riddles[_riddleIndex];
    }
    public static void RemoveRiddle()
    {
      riddles.RemoveAt(_riddleIndex);
      answers.RemoveAt(_riddleIndex);
    }
    public static string CheckAnswer()
    {
     return answers[_riddleIndex];
    }
  }    
}  