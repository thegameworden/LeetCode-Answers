//This problem can be found at: https://leetcode.com/problems/count-submatrices-with-all-ones

public class Solution 
{
    public int NumSubmat(int[][] mat) 
    {
        var n = mat.Length;
        var m = mat[0].Length;
        var numRectangles = 0;
        int[,] numOnes = new int[n, m];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = m - 1; j >= 0; j--)
            {
                if (mat[i][j] == 1)
                {
                    numOnes[i, j] = 1 + ((j < m - 1) ? numOnes[i, j + 1] : 0);
                }
            }
        }
        

        for (int i = 0; i < n; i++)
        {            
            for (int j = 0; j < m; j++)
            {
                if (mat[i][j] == 1)
                {
                   int minLength = Int32.MaxValue;
                
                    for (int k = i; k < n; k++)
                    {
                        minLength = Math.Min(minLength, numOnes[k, j]);
                        numRectangles += minLength;
                    }
                }
            }
        }
        
        return numRectangles;
    }
}
