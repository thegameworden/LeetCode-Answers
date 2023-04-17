//This problem can be found at: https://leetcode.com/problems/find-the-maximum-divisibility-score

public class Solution {
    public int MaxDivScore(int[] nums, int[] divisors) {
        List<int[]> list= new();
        for(int i=0;i<divisors.Length;i++){
            int count=0;
            for(int j=0;j<nums.Length;j++){
                if(nums[j]%divisors[i]==0) count++;
            }
          list.Add(new int[]{count,divisors[i]});
            
        }
        
        list.Sort(compare);
        return list[0][1];
        
    }
    
    private static int compare(int[] x,int[] y){
        if(x==null){
            if(y==null)
                return 0;
            return 0;
        }else if(y==null){
            return 1;
        }else{
            if(x[0]>y[0])
                return -1;
            if(x[0]<y[0])
                return 1;
            
            return x[1].CompareTo(y[1]);
        }
    }
}
