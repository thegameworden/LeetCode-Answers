//This problem can be found at: https://leetcode.com/problems/ransom-note

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> db = new Dictionary<char,int>();
        for(int i=0;i<magazine.Length;i++){
            if(db.ContainsKey(magazine[i])){
                db[magazine[i]]++;
            }else{
                db.Add(magazine[i],1);
            }
        }

        for(int i=0;i<ransomNote.Length;i++){
            if(!db.ContainsKey(ransomNote[i]) || db[ransomNote[i]]==0)
            return false;

         
            db[ransomNote[i]]--;

        }
        return true;
    }
}
