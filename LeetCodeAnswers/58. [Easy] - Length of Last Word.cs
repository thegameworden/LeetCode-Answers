//This problem can be found at: https://leetcode.com/problems/length-of-last-word

public class Solution {
    public int LengthOfLastWord(string s) {
        s=s.Trim();
        string[] ret = s.Split(' ');
        
        return ret[ret.Length-1].Length;
    }
}
