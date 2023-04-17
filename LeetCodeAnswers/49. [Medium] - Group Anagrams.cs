//This problem can be found at: https://leetcode.com/problems/group-anagrams

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> groups = new Dictionary<string,List<string>>();
        for(int i=0;i<strs.Length;i++){
            char[] temp = strs[i].ToCharArray();
            Array.Sort(temp);
            string sorted = new string(temp);
            if(groups.ContainsKey(sorted)){
                groups[sorted].Add(strs[i]);
            }else{
                groups.Add(sorted,new List<string>{strs[i]});
            }
        }
        
        List<IList<string>> ret = new List<IList<string>>();
        foreach(KeyValuePair<string,List<string>> kvp in groups){
            ret.Add(kvp.Value);
        }
        
        return ret;
    }
}
