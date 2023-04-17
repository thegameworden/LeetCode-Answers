//This problem can be found at: https://leetcode.com/problems/string-matching-in-an-array

public class Solution {
    public IList<string> StringMatching(string[] words) {
       HashSet<string> subs = new HashSet<string>();

        for(int i=0;i<words.Length;i++){
            for(int j=0;j<words.Length;j++){
               if(i==j){
                   continue;
               }

                if(words[i].Contains(words[j])){
                subs.Add(words[j]);
                }
            }
        }

        return subs.ToList();
    }
}
