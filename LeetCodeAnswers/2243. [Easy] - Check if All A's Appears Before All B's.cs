//This problem can be found at: https://leetcode.com/problems/check-if-all-as-appears-before-all-bs

public class Solution {
    public bool CheckString(string s) {
        bool firstB=false;

        for(int i=0;i<s.Length;i++){
            if(s[i]=='b')
            firstB=true;
            if(firstB&& s[i]=='a')
                return false;
        }
        return true;
    }
}
