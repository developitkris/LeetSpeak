using System
using System.Collections;
using System.Collections.Generic;


namespace LeetspeakApp
{
  public class Leetspeak
  {
    private string _inputSentence;
    private string[] toChange = { "e", "o", "I", "t", "s"};
    private string[] changed = {"3", "0", "1", "7", "z"};

    // private static List<string> _originalSplit = new List<string>{
    //   "e", "o", "I", "t", "s"
    // };
    // private static List<string> _translated = new List<string>{};
    public void SetInput(string input)
    {
      _inputSentence = input;
    }

    public string GetInput()
    {
      return _inputSentence;
    }

    public static string ConvertSentence(string userSentence)
    {
      return userSentence;
    }

    public static string ConvertIntoArr()
    {
      return _inputSentence
    }
    // public static string ConvertE(string e)
    // {
    //   for (var i = 0; i < e.Length; i++)
    //   {
    //     if (e[i] == "e")
    //     {
    //       e[i].Replace("e", "3");
    //     }
    //   }
    //   return e;
    // }

  }
}
