//This problem can be found at: https://leetcode.com/problems/find-lucky-integer-in-an-array

public class Solution {
    public int FindLucky(int[] arr) {
        Dictionary<int,int> luck = new Dictionary<int,int>();

        for(int i=0;i<arr.Length;i++){
            if(luck.ContainsKey(arr[i])){
                luck[arr[i]]++;
            }else{
                luck.Add(arr[i],1);
            }
        }

        int ret = -1;
        foreach(KeyValuePair<int,int> kvp in luck){
            if(kvp.Key == kvp.Value){
                if(kvp.Key> ret){
                    ret= kvp.Key;
                }
            }
        }

        return ret;
    }
}
