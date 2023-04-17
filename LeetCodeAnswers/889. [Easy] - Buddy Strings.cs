//This problem can be found at: https://leetcode.com/problems/buddy-strings

public class Solution {
    public bool BuddyStrings(string s, string goal) {
        if(s.Length!=goal.Length)return false;
        if(s.Equals(goal)){
            Dictionary<char,int> counter = new Dictionary<char,int>();
            for(int i=0;i<s.Length;i++){
                if(counter.ContainsKey(s[i])){
                    return true;
                }else{
                    counter.Add(s[i],1);
                }
            }
            return false;
        }else{
            int first= -1;
            int second=-1;
            for(int i=0;i<s.Length;i++){
               
                if(s[i]!=goal[i]){
                    if(first==-1){
                        first= i;  
                    }else if(second==-1){
                        second=i;
                        if(goal[i]!=s[first] || goal[first]!=s[i]){
                            return false;
                        }

                    }else{
                        return false;
                    }

                    
                }

            }
            if(first == -1 || second ==-1)
            return false;
        }
        return true;
    }
}
