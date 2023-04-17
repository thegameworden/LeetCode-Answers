//This problem can be found at: https://leetcode.com/problems/range-sum-query-mutable

public class NumArray {
    int[] arr;
    int total;
    public NumArray(int[] nums) {
        arr= nums;
        total=0;
        for(int i=0;i<nums.Length;i++){
            total+=nums[i];
        }
       
    }
    
    public void Update(int index, int val) {
        total-=arr[index];
        total+=val;
        arr[index]=val;
    }
    
    public int SumRange(int left, int right) {
        
        if(arr.Length/2<right-left){
            int ret=total;
            for(int i=0;i<left;i++){
                ret-=arr[i];
            }
            
            for(int i=right+1;i<arr.Length;i++){
                ret-=arr[i];
            }
            return ret;
            
            
        }    
    
        int sum=0;
        for(int i=left;i<=right;i++){
            sum+=arr[i];
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */
