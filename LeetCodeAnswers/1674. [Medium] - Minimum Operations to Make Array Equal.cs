//This problem can be found at: https://leetcode.com/problems/minimum-operations-to-make-array-equal

public class Solution {
    public int MinOperations(int n) {
      return (n/2)*(n-(n/2));
    }
}
/*
1:3
2:5
3:7
4:9
5:11
6:13

*/
