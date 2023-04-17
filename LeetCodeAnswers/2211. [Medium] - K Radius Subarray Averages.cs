//This problem can be found at: https://leetcode.com/problems/k-radius-subarray-averages

public class Solution {
    public int[] GetAverages(int[] nums, int k) {
        int div = 2*k+1;
        int[] ret = new int[nums.Length];

        ulong total=0;
        for(int i=0;i<div;i++){
            if(div>nums.Length) break;
            total+=(ulong)nums[i];
        }
        
       
        for(int i=0;i<ret.Length-1;i++){
            if(i<k || i> nums.Length-k-1)
            { 
               
                ret[i]=-1;

            }else{
               
                ret[i]=(int)(total/(ulong)div);
                if(i+k+1<nums.Length){
                total=total+(ulong)(-nums[i-k]+nums[i+k+1]);
                }
            }
        }

         if(k==0) ret[ret.Length-1] = nums[nums.Length-1];
            else ret[ret.Length-1] = -1;

        Console.WriteLine(nums.Length);
        Console.WriteLine(ret[ret.Length-1]);
        return ret;

    }
}


/*
ends: if i <=k Or i> nums.Length-k
                set = -1;

otherwise find average...
find average...
first average (calculate)

(nums[0]-> nums[k+1] (mid) -> nums[k+1+k])/(2k+1) 
7+4+3+9+1+8+5 / ( 2(3) +1)
= 5 int

next...
multiply average by 2k+1, - nums[i-k-1], + nums[i+k]



*/
