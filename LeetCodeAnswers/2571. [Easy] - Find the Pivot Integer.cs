//This problem can be found at: https://leetcode.com/problems/find-the-pivot-integer

public class Solution {
    public int PivotInteger(int n) {
        int left=1;
        int max= (n*(n+1))/2;
        int right = max;

        int pivot =1;
        while(left<right){
            pivot++;
            left = (pivot*(pivot+1))/2;
            right = max-left+pivot;
        }
        

        if(left==right)
        return pivot;

        return -1;
    }
}
