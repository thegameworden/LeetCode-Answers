//This problem can be found at: https://leetcode.com/problems/merge-two-2d-arrays-by-summing-values

public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        SortedDictionary<int,int> sorter = new();
        for(int i=0;i<nums1.Length;i++){
            sorter.Add(nums1[i][0],nums1[i][1]);
        }
        for(int i=0;i<nums2.Length;i++){
            if(sorter.ContainsKey(nums2[i][0])){
                sorter[nums2[i][0]]+=nums2[i][1];
            }else{
                sorter.Add(nums2[i][0],nums2[i][1]);
            }
        }
        
        int[][] ret = new int[sorter.Count][];
        int pointer=0;
        foreach(KeyValuePair<int,int> kvp in sorter){
            ret[pointer]= new int[]{kvp.Key,kvp.Value};
            pointer++;
        }

        return ret;

    }
}
