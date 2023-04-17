//This problem can be found at: https://leetcode.com/problems/richest-customer-wealth

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int richest =0;
        for(int y=0;y<accounts.Length;y++){
            int wealth=0;
            for(int x=0;x<accounts[y].Length;x++){
                wealth+=accounts[y][x];
            }
            if(richest<wealth)
            richest=wealth;

        }
        return richest;
    }
}
