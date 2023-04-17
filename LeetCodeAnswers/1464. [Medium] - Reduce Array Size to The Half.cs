//This problem can be found at: https://leetcode.com/problems/reduce-array-size-to-the-half

public class Solution {
    public int MinSetSize(int[] arr) {
        Dictionary<int, int> counters = new();
        for(int i=0;i<arr.Length;i++){
            if(counters.ContainsKey(arr[i]))
            counters[arr[i]]++;
            else
                counters.Add(arr[i],1);
        }

        PriorityQueue<int,int> q = new();
        foreach(KeyValuePair<int,int> kvp in counters){
            q.Enqueue(kvp.Value,-kvp.Value);
        }

        int counter =0;
        int half = arr.Length/2;
        while(half>0){
            half-=q.Dequeue();
            counter++;
        }
        return counter;
    }
}
