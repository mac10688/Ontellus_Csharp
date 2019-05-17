using System;
using Xunit;
using Library;

namespace Library.Tests
{
    public class PhoneNumberTests
    {
        [Fact]
        public void Number_With_Area_Code_Parentheses()
        {
          var result = PhoneNumber.TryParse("(555)555-5555", out PhoneNumber phoneNumber);
          Assert.Equal("555-555-5555", phoneNumber.ToString());
        }

        [Fact]
        public void Number_With_Area_Code_Dashes()
        {
          var result = PhoneNumber.TryParse("555-555-5555", out PhoneNumber phoneNumber);
          Assert.Equal("555-555-5555", phoneNumber.ToString()); 
        }

        [Fact]
        public void Number_With_No_Area_Code()
        {
          var result = PhoneNumber.TryParse("555-5555", out PhoneNumber phoneNumber);
          Assert.Equal("555-5555", phoneNumber.ToString());

        }
        
        [Fact]
        public void No_PhoneNumber_If_Just_Numbers()
        {
          var result = PhoneNumber.TryParse("5555555555", out PhoneNumber phoneNumber);
          Assert.False(result, "PhoneNumbers need some type of formatting to parse.");

        }
    }
}
