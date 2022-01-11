namespace _3._1Integer_to_Roman
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(3));
        }

        public static readonly int[] Values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        public static readonly string[] Symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public static string IntToRoman(int num)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Values.Length && num > 0; i++)
            {
                while (Values[i] <= num)
                {
                    num -= Values[i];
                    result.Append($"{Symbols[i]}");
                }
            }

            return result.ToString();
        }
    }
}