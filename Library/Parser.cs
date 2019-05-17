using System;

namespace Library
{
  public class Parser
  {
    
    public static ParseResult ParseArray(string[] args)
    {
      var result = new ParseResult();
      foreach(var arg in args)
      {
        if(DateTime.TryParse(arg, out DateTime date))
        {
          result.Dates.Add(date);
        }
        else if(PhoneNumber.TryParse(arg, out PhoneNumber phoneNumber))
        {
          result.PhoneNumbers.Add(phoneNumber);
        } 
        else if (Word.TryParse(arg, out Word word))
        {
          result.Words.Add(word);
        }
        else if (Decimal.TryParse(arg, out Decimal number))
        {
          result.Numbers.Add(number);
        }
      }
      return result;
    }

  }
}
