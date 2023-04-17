//This problem can be found at: https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time

public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        int working = 0;
        for(int i=0;i<startTime.Length;i++){
            if(queryTime >=startTime[i]  && queryTime <= endTime[i])
            working++;
        }

        return working;
    }
}
