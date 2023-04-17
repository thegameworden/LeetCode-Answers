//This problem can be found at: https://leetcode.com/problems/student-attendance-record-i

public class Solution {
    public bool CheckRecord(string s) {
        int ACount =0;
        int lateConsec=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='A'){
                ACount++;
                if(ACount>=2){
                    return false;
                }
            }
            
            if(s[i]=='L'){
                lateConsec++;
                if(lateConsec>=3){
                    return false;
                }
            }else{
                lateConsec=0;
            }
        }
        return true;
    }
}
