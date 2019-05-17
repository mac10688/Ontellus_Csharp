using System.Text.RegularExpressions;
using System;

namespace Library
{
  public class PhoneNumber : IComparable
  {
    private readonly string _phoneNumber;
    private const string _phoneNumberPattern = @"^\d{3}-\d{3}-\d{4}$";
    
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
      return _phoneNumber;
    }
  }
}
