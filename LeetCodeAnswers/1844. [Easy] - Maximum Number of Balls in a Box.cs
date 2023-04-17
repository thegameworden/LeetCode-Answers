//This problem can be found at: https://leetcode.com/problems/maximum-number-of-balls-in-a-box

public class Solution {
    public int CountBalls(int lowLimit, int highLimit) {
        Dictionary<int,int> boxes = new();
        int max =0;
        for(int i=lowLimit;i<=highLimit;i++){
            int num = i;
            int box = 0; 
            while(num>0){
                int adder = num%10;
                box+=adder;
                num/=10;
            }
            if(!boxes.ContainsKey(box)){
                boxes.Add(box,1);
            }else{
                boxes[box]++;
            }
            max= Math.Max(max,boxes[box]);
        }
        return max;
    }
}
