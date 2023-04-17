//This problem can be found at: https://leetcode.com/problems/delete-columns-to-make-sorted

public class Solution {
    public int MinDeletionSize(string[] strs) {
       int count=0;
        for(int x= 0;x<strs[0].Length;x++){
            for(int y=1;y<strs.Length;y++){
                if(strs[y][x]<strs[y-1][x]){
                count++;
                break;
                }
            }
        }
        return count;
    }
}
