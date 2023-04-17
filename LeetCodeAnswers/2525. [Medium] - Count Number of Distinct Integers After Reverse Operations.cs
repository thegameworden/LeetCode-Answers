//This problem can be found at: https://leetcode.com/problems/count-number-of-distinct-integers-after-reverse-operations

public class Solution {
    public int CountDistinctIntegers(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            set.Add(nums[i]);
            int revNum =0;
            while(nums[i]>0){
                revNum*=10;
                revNum+=nums[i]%10;
                nums[i]/=10;
            }

            set.Add(revNum);
        }

         return set.Count;
    }

   


}

/*
while(num >10){
revNum*10;
revNum+=num%10;
}

revNum=0;
13


30+1=31

*/
