//This problem can be found at: https://leetcode.com/problems/maximum-swap

public class Solution {
    public int MaximumSwap(int num) {
        string swap = num.ToString();
        char[] sorted = swap.ToArray();
        int max = num;
        for(int i=0;i<sorted.Length-1;i++){
            for(int j=i+1;j<sorted.Length;j++){
                char c = sorted[j];
                sorted[j]= sorted[i];
                sorted[i]= c;
                int test = Convert.ToInt32(new string(sorted));
                if(test>max)
                    max=test;
                    
                sorted[i]= sorted[j];
                sorted[j]=c;
            }
        }

        return max;

    }
}
