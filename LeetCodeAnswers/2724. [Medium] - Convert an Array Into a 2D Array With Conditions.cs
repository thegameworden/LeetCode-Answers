//This problem can be found at: https://leetcode.com/problems/convert-an-array-into-a-2d-array-with-conditions

public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        Dictionary<int,int> counter = new();
        for(int i=0;i<nums.Length;i++){
            if(!counter.ContainsKey(nums[i])){
                counter.Add(nums[i],1);
            }else{
                counter[nums[i]]++;
            }
        }
        
        int unique = counter.Count;
        
        List<IList<int>> ret = new();
        while(unique>0){
            List<int> adder = new();
            foreach(KeyValuePair<int,int> kvp in counter){
                if(kvp.Value!=0){
                    adder.Add(kvp.Key);
                    counter[kvp.Key]--;
                    if(counter[kvp.Key]==0)unique--;
                }
            }
            ret.Add(adder);
        }
        return ret;
    }
}
