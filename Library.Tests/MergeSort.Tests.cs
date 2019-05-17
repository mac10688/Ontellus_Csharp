using System;
using System.Collections.Generic;
using Xunit;
using Library;

namespace Library.Tests
{
    public class MergeSortTests
    {
        [Fact]
        public void SortDateTime()
        {
          var unsortedDates = new List<DateTime>()
          {
            new DateTime(1999, 12, 05),
            new DateTime(1995, 08, 21),
            new DateTime(2001, 09, 11)
          };

          var sortedDates = MergeSort.Sort(unsortedDates);

          Assert.Equal(new DateTime(1995, 08, 21), sortedDates[0]);
          Assert.Equal(new DateTime(1999, 12, 05), sortedDates[1]);
          Assert.Equal(new DateTime(2001, 09, 11), sortedDates[2]);
        }

        [Fact]
        public void RemovesDuplicates()
        {
          var unsorted = new List<Decimal>()
          {
            1,
            2,
            4,
            2,
            1
          };

          var sortedNumbers = MergeSort.Sort(unsorted);
          var expected = new List<Decimal>{ 1,2,4 };

          Assert.Equal(expected.Count, sortedNumbers.Count);

          for(var i = 0; i < sortedNumbers.Count; i++)
          {
            var sortedNum = sortedNumbers[i];
            var expectedNum = expected[i];
            Assert.Equal(expectedNum, sortedNum);
          }
        }

    }
}
