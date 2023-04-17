//This problem can be found at: https://leetcode.com/problems/count-total-number-of-colored-cells

public class Solution {
    public long ColoredCells(int n) {
        if(n ==1) return 1;

        long ret =1;
        for(int i=1;i<n;i++){
            ret+= 4*i;
        }
        return ret;
        

    }
}

/*
1: 1
2: 1 + 4(1)
3: 1 + 4 + 4(2) 
4: 1 + 4 + 8 + 4(3)
5: .   .   .    .   + 4(4)

*/
