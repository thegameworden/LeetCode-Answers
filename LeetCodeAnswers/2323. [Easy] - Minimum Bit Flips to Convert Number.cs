//This problem can be found at: https://leetcode.com/problems/minimum-bit-flips-to-convert-number

public class Solution {
    public int MinBitFlips(int start, int goal) {
        string num = Convert.ToString((start^goal),2);
        int count = 0;
        for(int i=0;i<num.Length;i++){
            if(num[i]=='1')
            count++;
        }
        return count;
    }
}
