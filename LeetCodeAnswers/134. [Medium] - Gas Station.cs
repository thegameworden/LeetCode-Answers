//This problem can be found at: https://leetcode.com/problems/gas-station

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int startingStation =0;
        int cTank=0;
        int tTank =0;
        for(int i=0;i<gas.Length;i++){
            tTank+=gas[i]-cost[i];
            cTank+=gas[i]-cost[i];
            if(cTank<0){
                cTank=0;
                startingStation=i+1;
            }
        }

        if(tTank>=0)
        return startingStation;

        return -1;
    }
}
