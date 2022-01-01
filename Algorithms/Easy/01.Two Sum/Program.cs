using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Two_Sum
{
    /*Given an array of integers nums and an integer target,
      return indices of the two numbers such that they add up to target.
      You may assume that each input would have exactly one solution,
      and you may not use the same element twice.*/
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] separators = new string[] { " ", ",", ", " };
            Console.Write("Enter sequence of nums: ");
            int[] nums = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            if (nums.Length == 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            Console.Write("Enter target num: ");
            int target = int.Parse(Console.ReadLine());

            int[] indexes = TwoSum_2(nums, target);
            if (indexes is null)
            {
                Console.WriteLine("There is no summary that response to your target!");
                return;
            }

            Console.WriteLine($"Result: {nums[indexes[0]]} and {nums[indexes[1]]}");
            Console.WriteLine($"Result: {indexes[0]} and {indexes[1]}");
        }

        //2 7 11 15
        //3 2 3
        public static int[] TwoSum_1(int[] nums, int target)
        {
            int[] indexes = new int[2];
            int previousNumber = 0;
            int currentNumber = 0;
            int sum = 0;
            bool isFound = false;

            for (int i = 0; i < nums.Length; i++)
            {
                previousNumber = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    currentNumber = nums[j];
                    sum = previousNumber + currentNumber;
                    if (sum == target)
                    {
                        indexes[0] = i;
                        indexes[1] = j;
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    return indexes;
                }
            }

            return null;
        }

        public static int[] TwoSum_2(int[] nums, int target)
        {
            Dictionary<int, int> numsAndIndexes = new Dictionary<int, int>();

            int difference = 0;
            int currentNumber = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                currentNumber = nums[i];
                difference = target - currentNumber;
                int index = 0;

                if (numsAndIndexes.TryGetValue(difference, out index))
                {
                    return new int[] { index, i };
                }

                if (numsAndIndexes.ContainsKey(currentNumber) == false)
                {
                    numsAndIndexes.Add(currentNumber, i);
                }
            }

            return null;
        }
    }
}