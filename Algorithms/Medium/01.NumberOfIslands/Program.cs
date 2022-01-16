namespace _01.NumberOfIslands
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int NumIslands(char[][] grid)
        {
            int islandCount = 0;
            char currentCharacter;
            char islandChar = '1';

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    currentCharacter = grid[row][col];
                    if (currentCharacter == islandChar)
                    {
                        islandCount++;

                        BFS(grid, row, col);
                    }
                }
            }

            return islandCount;
        }

        public void BFS(char[][] area, int row, int col)
        {
            if (ValidatePosition(area, row, col))
            {
                return;
            }

            area[row][col] = '0';
            //Up
            BFS(area, row+1, col);
            //Down
            BFS(area, row-1, col);
            //Left
            BFS(area, row, col-1);
            //Right
            BFS(area, row, col+1);
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