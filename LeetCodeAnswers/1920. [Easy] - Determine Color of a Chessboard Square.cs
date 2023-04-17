//This problem can be found at: https://leetcode.com/problems/determine-color-of-a-chessboard-square

public class Solution {
    public bool SquareIsWhite(string coordinates) {
        return !(coordinates[0]%2 == coordinates[1]%2);

    }
}
