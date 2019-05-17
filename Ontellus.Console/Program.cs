using System;
using Library;
using System.Collections.Generic;

namespace Ontellus.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var parseResult = Parser.ParseArray(args); 

            System.Console.WriteLine("Dates:");

            var sortedDates = MergeSort.Sort(parseResult.Dates);
            foreach(var date in sortedDates)
            {
              System.Console.WriteLine(date);
            }

            System.Console.WriteLine("\n\nPhoneNumbers:");

            var sortedPhoneNumbers = MergeSort.Sort(parseResult.PhoneNumbers);
            foreach(var phoneNumber in sortedPhoneNumbers)
            {
              System.Console.WriteLine(phoneNumber);
            }

            System.Console.WriteLine("\n\nWords:");

            var sortedWords = MergeSort.Sort(parseResult.Words);
            foreach(var word in sortedWords)
            {
              System.Console.WriteLine(word);
            }

            var sortedNumbers = MergeSort.Sort(parseResult.Numbers);

            System.Console.WriteLine("\n\nNumbers:");
            foreach(var number in sortedNumbers)
            {
              System.Console.WriteLine(number);
            }
        }
    }
}
