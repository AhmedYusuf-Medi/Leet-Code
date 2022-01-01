using System;

namespace _02.Palindrome_Number
{
    /*Given an integer x, return true if x is palindrome integer.
      An integer is a palindrome when it reads the same backward as forward.
      For example, 121 is a palindrome while 123 is not.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome_2(121).ToString().ToLower());
        }

        //Too slow
        public static bool IsPalindrome_1(int x)
        {
            long revert = 0;
            int number = x;

            while (number > 0)
            {
                revert = revert * 10 + number % 10;
                number /= 10;
            }

            return revert == x;
        }

        public static bool IsPalindrome_2(int x)
        {
            //Negative number cannot be palindrome
            if (x < 0)
            { 
                return false; 
            }

            //Number of digits
            var len = (int)Math.Log10(x);

            while (x != 0)
            {
                //From left to right
                var low = x % 10;
                //From right to left
                var high = x / (int)Math.Pow(10, len);

                if (low != high)
                {
                    return false;
                }

                x = x % (int)Math.Pow(10, len) / 10;

                len -= 2;
            }

            return true;
        }
    }
}