//This problem can be found at: https://leetcode.com/problems/number-of-laser-beams-in-a-bank

public class Solution {
    public int NumberOfBeams(string[] bank) {
        int total=0;
        if(bank.Length==1) return total;
        int topCount =getLaserCount(bank,0);

        

        for(int i=1;i<bank.Length;i++){
            int check=getLaserCount(bank,i);
            if(check>0){
                total+=check*topCount;
                topCount=check;
            }
        }
        return total;
    }

    private int getLaserCount(string[] bank, int index){
        int ret = 0;
        for(int i=0;i<bank[index].Length;i++){
            if(bank[index][i]=='1')
            ret++;
        }
        return ret;
    }
}

/*
total =0
topRow
followingRow
total+= topRowBeams*followingRowBeams

...

return total;

*/
