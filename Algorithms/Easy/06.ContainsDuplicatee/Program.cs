namespace _06.ContainsDuplicatee
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
        }

        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return false;
            }

            Array.Sort(nums);

            int currentNumber = 0;
            int nextNumber = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                currentNumber = nums[i];
                nextNumber = nums[i + 1];

                if (currentNumber == nextNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}