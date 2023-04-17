//This problem can be found at: https://leetcode.com/problems/fibonacci-number

public class Solution {
    public int Fib(int n) {
        if(n<2){
        return n;
        }
        int[] fib = new int[n+1];
        fib[0]=0;
        fib[1]=1;
        

        for(int i=2;i<fib.Length;i++){
            fib[i]=fib[i-1]+fib[i-2];
        }
        return fib[fib.Length-1];
    }
}
