//This problem can be found at: https://leetcode.com/problems/intersection-of-two-arrays-ii

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> db = new Dictionary<int, int>();
        for(int i=0;i<nums1.Length;i++){
            if(db.ContainsKey(nums1[i])){
                db[nums1[i]]++;
            }else{
                db.Add(nums1[i],1);
            }
        }
        
        List<int> ret = new List<int>();
        for(int i=0;i<nums2.Length;i++){
            if(!db.ContainsKey(nums2[i]) || db[nums2[i]]==0){
                continue;
            }
            ret.Add(nums2[i]);
            db[nums2[i]]--;
        }
        
        return ret.ToArray();
        
    }
}
