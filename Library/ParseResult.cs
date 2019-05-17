using System;
using System.Collections.Generic;

namespace Library
{
  public class ParseResult
  {
    public List<DateTime> Dates { get; set; } = new List<DateTime>();
    public List<PhoneNumber> PhoneNumbers = new List<PhoneNumber>();
    public List<Word> Words = new List<Word>();
    public List<Decimal> Numbers = new List<Decimal>();
  }
}
