//This problem can be found at: https://leetcode.com/problems/snakes-and-ladders

    public class Solution
    {
        public int SnakesAndLadders(int[][] board)
        {
            int n = board.Length;

            Queue<int> bfs = new Queue<int>();
            bfs.Enqueue(1);
            if (board[0][0] != -1)
            {
                return -1;
            }
            ISet<int> visited = new HashSet<int>();
            visited.Add(1);
            int res = 0;

            while (bfs.Count > 0)
            {
                int count = bfs.Count;
                for (int i = 0; i < count; i++)
                {
                    var current = bfs.Dequeue();

                    if (current == n * n)
                    {
                        return res;
                    }

                    for (int j = 1; j <= 6; j++)
                    {
                        int next = current + j;
                        if (next > n * n)
                        {
                            break;
                        }


                        int shiftedIdx = next - 1;
                        int row = shiftedIdx / n;
                        int col = shiftedIdx % n;

                        if (row % 2 == 1)
                        {
                            col = (n - 1) - col;
                        }

                        row = (n - 1) - row;

                        if (board[row][col] != -1)
                        {
                            next = board[row][col];
                        }

                        if (visited.Add(next))
                        {
                            bfs.Enqueue(next);
                        }
                    }
                }
                res++;
            }

            return -1;
        }
    }
