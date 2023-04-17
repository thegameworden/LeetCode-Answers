//This problem can be found at: https://leetcode.com/problems/optimal-partition-of-string

public class Solution {
    public int PartitionString(string s) {
        int min =1;
      HashSet<char> unique= new();
        for(int i=0;i<s.Length;i++){
            if(!unique.Add(s[i])){
                min++;
                unique.Clear();
                unique.Add(s[i]);
            }
        }

        return min;
    }
}
