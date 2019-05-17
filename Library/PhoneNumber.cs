using System.Text.RegularExpressions;
using System;

namespace Library
{
  public class PhoneNumber : IComparable
  {
    private readonly string _phoneNumber;
    //This regex is a modified version of https://stackoverflow.com/questions/18091324/regex-to-match-all-us-phone-number-formats
    private const string _phoneNumberPattern = @"(\(\d{3}\)|(\d{3})-)?\d{3}-\d{4}";
    
    private PhoneNumber(string phoneNumber)
    {
      _phoneNumber = phoneNumber;
    }

    public static bool TryParse(string test, out PhoneNumber phoneNumber)
    {
      if(test == null)
      {
        phoneNumber = null;
        return false;
      }
       Regex rx = new Regex(_phoneNumberPattern, RegexOptions.Compiled);
       var isMatch = rx.IsMatch(test);

       if (isMatch)
       {
          var matches = Regex.Matches(test, @"\d+");
          var numberString = "";

          foreach(Match match in matches)
          {
            numberString += match.Value;
          }

          phoneNumber = new PhoneNumber(numberString);
       }
       else
       {
        phoneNumber = null;
       }

       return isMatch;
    }

    public int CompareTo(object obj)
    {
      var otherNumber = obj as PhoneNumber;
      return _phoneNumber.CompareTo(otherNumber._phoneNumber);
    }

    public override string ToString()
    {
      if (_phoneNumber.Length == 7)
      {
        return Convert.ToInt64(_phoneNumber).ToString("###-####");
      }
      else
      {
        return Convert.ToInt64(_phoneNumber).ToString("###-###-####");
      }
    }
  }
}
