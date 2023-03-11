using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTest
{
    class Program
    {
        public static long repeatedString(string s, long n)
        {
            long aCount = 0;
            long sLength = s.Length;

            // Count the number of "a"s in a single occurrence of the string "s".
            for (int i = 0; i < sLength; i++)
            {
                if (s[i] == 'a')
                {
                    aCount++;
                }
            }

            // Calculate the total number of "a"s in the repeated string.
            long totalACount = aCount * (n / sLength);

            // Count the remaining "a"s in the partial occurrence of "s".
            for (int i = 0; i < n % sLength; i++)
            {
                if (s[i] == 'a')
                {
                    totalACount++;
                }
            }

            return totalACount;


        }
        static void Main(string[] args)
        {
            Console.WriteLine(repeatedString("a", 1000000000000));
        }
    }
}