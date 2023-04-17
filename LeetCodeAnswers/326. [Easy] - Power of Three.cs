//This problem can be found at: https://leetcode.com/problems/power-of-three

public class Solution {
    public bool IsPowerOfThree(int n) {
        return n>0 && 1162261467%n==0;
    }
}
