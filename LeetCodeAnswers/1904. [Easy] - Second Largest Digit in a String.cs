//This problem can be found at: https://leetcode.com/problems/second-largest-digit-in-a-string

public class Solution {
    public int SecondHighest(string s) {
        SortedSet<int> ss= new SortedSet<int>();

        for(int i=0;i<s.Length;i++){
            if((int)s[i]<=57){
               ss.Add((int)s[i]-48);
            }
        }
       
       if(ss.Count<=1){
           return -1;
       }
       return ss.ElementAt(ss.Count-2);
    }
}
