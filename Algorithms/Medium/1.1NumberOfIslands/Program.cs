namespace _1._1NumberOfIslands
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int NumIslands(char[][] grid)
        {
            int islandCount = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (FindIsland(grid, row, col))
                    {
                        islandCount++;
                    }
                }
            }

            return islandCount;
        }

        public bool FindIsland(char[][] area, int row, int col)
        {
            if (ValidatePosition(area, row, col))
            {
                return false;
            }

            if (area[row][col] == '1')
            {
                area[row][col] = '0';
                //Up
                FindIsland(area, row + 1, col);
                //Down
                FindIsland(area, row - 1, col);
                //Left
                FindIsland(area, row, col - 1);
                //Right
                FindIsland(area, row, col + 1);

                return true;
            }

            return false;
        }

        private static bool ValidatePosition(char[][] area, int row, int col)
        {
            return row < 0
                || row >= area.Length
                || col < 0
                || col >= area[row].Length
                || area[row][col] == '0';
        }
    }
}