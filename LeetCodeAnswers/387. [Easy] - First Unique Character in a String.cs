//This problem can be found at: https://leetcode.com/problems/first-unique-character-in-a-string

public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,List<int>> count = new Dictionary<char,List<int>>();
        for(int i =0;i<s.Length;i++){
            if(count.ContainsKey(s[i])){
                count[s[i]].Add(i);
            }else{
                count.Add(s[i],new List<int>{i});
            }
        }
        
        for(int i=0;i<s.Length;i++){
            if(count[s[i]].Count==1){
                return count[s[i]][0];
            }
        }
        return -1;
        
    }
}
