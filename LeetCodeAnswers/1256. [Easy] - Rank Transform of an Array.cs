//This problem can be found at: https://leetcode.com/problems/rank-transform-of-an-array

public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        int rank = 1;
        Dictionary<int,int> nums = new Dictionary<int,int>();
        int[] copy = new int[arr.Length];
            Array.Copy(arr,copy,arr.Length);
            Array.Sort(arr);
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine(arr[i]);
            if(!nums.ContainsKey(arr[i])){
                nums.Add(arr[i],rank);
                rank++;
            }
            
        }
        
        for(int i=0;i<arr.Length;i++){
            copy[i]=nums[copy[i]];
        }
        return copy;
    }
}
