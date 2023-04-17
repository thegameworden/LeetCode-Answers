//This problem can be found at: https://leetcode.com/problems/moving-average-from-data-stream

public class MovingAverage {
Queue<int> nums;
    int maxSize;
    public MovingAverage(int size) {
        maxSize= size;
        nums = new Queue<int>();
    }
    
    public double Next(int val) {
    
        if(nums.Count == maxSize){
            nums.Dequeue();
        }
        nums.Enqueue(val);
        
        double temp=0;
        
        foreach(int i in nums){
    
            temp+=i;
        }
        
        return (double)temp/nums.Count;

    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */
