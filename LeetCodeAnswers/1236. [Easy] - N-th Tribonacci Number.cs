//This problem can be found at: https://leetcode.com/problems/n-th-tribonacci-number

public class Solution {
    public int Tribonacci(int n) {
       if(n==0)return 0;
       if(n==1)return 1;
       if(n==2) return 1;

        int[] trib = new int[n+1];
        trib[0]=0;
        trib[1]=1;
        trib[2]=1;
        for(int i=3;i<trib.Length;i++){
            trib[i]=trib[i-1]+trib[i-2]+trib[i-3];
        }

        return trib[trib.Length-1];
    }
}
