//This problem can be found at: https://leetcode.com/problems/find-all-lonely-numbers-in-the-array

public class Solution {
    public IList<int> FindLonely(int[] nums) {
        Dictionary<int,int> lonelyCheck = new();
        for(int i=0;i<nums.Length;i++){
             if(lonelyCheck.ContainsKey(nums[i])){
             lonelyCheck[nums[i]]++;
             }else{
                 lonelyCheck.Add(nums[i],1);
             }
        }
        List<int> lonely = new List<int>();
        foreach(KeyValuePair<int,int> kvp in lonelyCheck){
            if(kvp.Value==1 && !lonelyCheck.ContainsKey(kvp.Key-1)&& !lonelyCheck.ContainsKey(kvp.Key+1))
            lonely.Add(kvp.Key);
        }

        return lonely;
    }
}
