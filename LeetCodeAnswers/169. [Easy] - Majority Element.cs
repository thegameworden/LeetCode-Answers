//This problem can be found at: https://leetcode.com/problems/majority-element

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> major = new Dictionary<int,int>();
        foreach(int i in nums){
            if(major.ContainsKey(i)){
                major[i]++;
            }else{
                major.Add(i,1);
            }
        }
        return major.Aggregate((l,r)=> l.Value >r.Value? l:r).Key;
}}
