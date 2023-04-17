//This problem can be found at: https://leetcode.com/problems/find-anagram-mappings

public class Solution {
    public int[] AnagramMappings(int[] nums1, int[] nums2) {
        Dictionary<int,int> map = new();//num, position on nums2
        for(int i=0;i<nums2.Length;i++){
            if(map.ContainsKey(nums2[i]))
                continue;
            map.Add(nums2[i],i);
        }
    for(int i=0;i<nums1.Length;i++){
        nums1[i]=map[nums1[i]]; 
    }
        return nums1;
    
    }

    
}
