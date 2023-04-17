//This problem can be found at: https://leetcode.com/problems/number-of-lines-to-write-string

public class Solution {
    public int[] NumberOfLines(int[] widths, string s) {
        int numLines=0;
        int pointer=0;
        int rowUse=0;
        //Console.WriteLine((int)'a'); a=97

        
        while(pointer<s.Length){
        int add= widths[(int)s[pointer]-97];
        if(rowUse+add>100){
            rowUse=add;
            numLines++;
        }else{
            rowUse+=add;
        }
            pointer++;
        }

        if(rowUse!=0)
            numLines+=1;

        int[] ret = new int[]{numLines,rowUse};
        return ret;
    }
}
