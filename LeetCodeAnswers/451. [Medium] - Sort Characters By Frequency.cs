//This problem can be found at: https://leetcode.com/problems/sort-characters-by-frequency

public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> freq = new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++){
            if(freq.ContainsKey(s[i])){
                freq[s[i]]++;
            }else{
                freq.Add(s[i],1);
            }
        }
        PriorityQueue<char,int> q = new PriorityQueue<char,int>(Comparer<int>.Create((x, y) => y - x));

        foreach(KeyValuePair<char,int> kvp in freq){
            q.Enqueue(kvp.Key,kvp.Value);
        }

        StringBuilder sb = new StringBuilder();
        char c=' ';
        int counter=0;
        while(q.Count!=0){
            q.TryDequeue(out c, out counter);
            for(int i=0;i<counter;i++){
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
