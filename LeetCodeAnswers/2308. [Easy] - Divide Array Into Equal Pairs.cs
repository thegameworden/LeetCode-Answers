//This problem can be found at: https://leetcode.com/problems/divide-array-into-equal-pairs

public class Solution {
    public bool DivideArray(int[] nums) {
        Dictionary<int,int> pairing = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(pairing.ContainsKey(nums[i])){
                pairing[nums[i]]++;
            }else{
                pairing.Add(nums[i],1);
            }
        }
        
        foreach(KeyValuePair<int,int> kvp in pairing){
            if(kvp.Value %2==1){
                return false;
            }
        }
        return true;
    }
}
