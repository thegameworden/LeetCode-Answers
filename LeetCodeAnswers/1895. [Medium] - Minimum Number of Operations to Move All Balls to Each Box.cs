//This problem can be found at: https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box

public class Solution {
    public int[] MinOperations(string boxes) {
        int[] ret = new int[boxes.Length];
        
        for(int i=0;i<ret.Length;i++){
            int counter=0;
            for(int j=0;j<boxes.Length;j++){
                if(boxes[j]=='1'){
                    counter+=Math.Abs(i-j);
                }
            }
            ret[i]=counter;
        }
        return ret;
    }
}
