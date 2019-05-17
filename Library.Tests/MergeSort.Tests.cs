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

    }
}
