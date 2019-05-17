using System;
using Xunit;

namespace Library.Tests
{
  public class DateTimeTests
  {
    
    [Fact]
    public void JustDate()
    {
      var isDate = DateTime.TryParse("05/29/2015", out DateTime date);

      Assert.Equal(date, new DateTime(2015, 5, 29, 0, 0, 0));
    }

    [Fact]
    public void NoteADate()
    {
      var isDate = DateTime.TryParse("234234", out DateTime date);
      Assert.False(isDate, "Numbers are not a date");
    }

  }
}
