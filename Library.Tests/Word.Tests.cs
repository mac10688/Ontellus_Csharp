using System;
using Xunit;
using Library;

namespace Library.Tests
{
    public class WordTests
    {
        [Fact]
        public void Negative_Numbers()
        {
          var result = Word.TryParse("234", out Word word);
          Assert.False(result, "Numbers are not words");
        }

        [Fact]
        public void Positive_Word()
        {
          var result = Word.TryParse("Romeo", out Word word);
          Assert.Equal("Romeo", word.ToString()); 
        }
    }
}
