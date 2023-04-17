//This problem can be found at: https://leetcode.com/problems/unique-number-of-occurrences

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> counter = new Dictionary<int,int>();
        for(int i=0;i<arr.Length;i++){
            if(counter.ContainsKey(arr[i])){
                counter[arr[i]]++;
            }else{
                counter.Add(arr[i],1);
            }
        }
        
        HashSet<int> unique = new HashSet<int>();
        foreach(KeyValuePair<int,int> kvp in counter){
                unique.Add(kvp.Value);
        }
        if(unique.Count == counter.Count)
            return true;
        
        return false;
        
    }
}
