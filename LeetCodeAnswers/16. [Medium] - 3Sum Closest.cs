//This problem can be found at: https://leetcode.com/problems/3sum-closest

public class Solution {
    public int ThreeSumClosest(int[] nums, int target)
        {

            int n = nums.Length;
            int min = Int32.MaxValue;
            int prevSum = Int32.MaxValue;
            // Sort.
            Array.Sort(nums);
            // -4,-1,1,2
            for (int i = 0; i < n; i++)
            {
                int low = i + 1;
                int high = n - 1;
                while (low < high)
                {
                    int sum = nums[low] + nums[high] + nums[i];
                    // get the distance from target
                    int distance = Math.Abs(target - sum);

                    if (sum < target || low > i + 1 && nums[low] == nums[low - 1])
                        low++;
                    else if (sum > target || high < n - 1 && nums[high] == nums[high + 1])
                        high--;
                    else
                        return sum;

                    if (distance < Math.Abs(min))
                    {
                        min = distance;
                        prevSum = sum;
                    }



                    //min = Math.Min(abs(target-sum), min);
                }
            }
            return prevSum;
        }
}
