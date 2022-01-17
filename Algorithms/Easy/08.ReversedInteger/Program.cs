namespace _08.ReversedInteger
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int Revers(int x)
        {
            int reversedX = 0;
            int currentNum = 0;

            while (x != 0)
            {
                currentNum = x % 10;
                x /= 10;

                reversedX = (reversedX * 10) + currentNum;
            }

            return reversedX;
        }
    }
}