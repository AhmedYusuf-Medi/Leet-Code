using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt_2("III"));
        }

        static readonly IDictionary<char, int> RomanValues =
        new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

        static int RomanToInt_1(string s)
        {
            int result = 0;
            int previous = 0;
            int current = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                current = RomanValues[s[i]];

                if (previous > current)
                {
                    result -= current;
                }
                else
                {
                    result += current;
                }

                previous = current;
            }

            return result;
        }

        static int RomanToInt_2(IEnumerable<char> romanNumerals)
        {
            int result = 0;
            char currentSymbol;

            for (int i = romanNumerals.Count() - 1; i >= 0; i--)
            {
                currentSymbol = romanNumerals.ElementAt(i);

                if (!RomanValues.ContainsKey(currentSymbol))
                {
                    throw new InvalidOperationException($"Doesn't exist such a roman numeral {currentSymbol}");
                }

                bool operation = romanNumerals.Skip(i).Any(rn => RomanValues[rn] > RomanValues[currentSymbol]);

                if (operation)
                {
                    result -= RomanValues[currentSymbol];
                }
                else
                {
                    result += RomanValues[currentSymbol];
                }
            }

            return result;
        }
    }
}