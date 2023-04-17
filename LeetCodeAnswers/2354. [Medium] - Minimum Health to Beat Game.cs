//This problem can be found at: https://leetcode.com/problems/minimum-health-to-beat-game

public class Solution {
    public long MinimumHealth(int[] damage, int armor) {

        int optimalLevel=damage[0];
        for(int i=1;i<damage.Length;i++){
            if(damage[i]>optimalLevel)
            optimalLevel=damage[i];
        }

        long health = 0;
        bool armorUsed=false;
        for(int i=0;i<damage.Length;i++){
            if(damage[i]==optimalLevel && !armorUsed){
                if(damage[i]>armor)
                health+=damage[i]-armor;

                armorUsed=true;
            }else{
                health+=damage[i];
            }

        }
        return health+1;
    }
}
