using System;
using System.Text.RegularExpressions;

namespace Library
{
  public class Word : IComparable
  {
    private readonly string _word;

    private Word(string word)
    {
      _word = word;
    }
    
    public static bool TryParse(string test, out Word word)
    {
      if(string.IsNullOrEmpty(test))
      {
        word = null;
        return false;
      }

      //https://stackoverflow.com/questions/1181419/verifying-that-a-string-contains-only-letters-in-c-sharp
      var regx = new Regex(@"^[a-zA-Z]+$");
      var isMatch = regx.IsMatch(test);

      if(isMatch)
      {
        var match = regx.Match(test);
        word = new Word(match.Value);

      }
      else
      {
        word = null;
      }

      return isMatch;
    }

    public int CompareTo(object obj)
    {
      var otherWord = obj as Word;
      return _word.CompareTo(otherWord._word);
    }

    public override string ToString()
    {
      return _word;
    }
    
  }

}
