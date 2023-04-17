//This problem can be found at: https://leetcode.com/problems/can-place-flowers

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(flowerbed.Length==1){
            if(flowerbed[0]==1 && n<1)
            return true;
            if(flowerbed[0]==0 && n<=1)
            return true;
            
            return false;
        }
        if(flowerbed[0]==0 && flowerbed[1]==0){
            flowerbed[0]=1;
            n--;
        }

        for(int i=1;i<flowerbed.Length-1;i++){
            if(flowerbed[i-1] ==0 && flowerbed[i+1]==0 && flowerbed[i]==0){
                flowerbed[i]=1;
                n--;
            }
        }

        if(flowerbed[flowerbed.Length-1]==0 && flowerbed[flowerbed.Length-2]==0){
            flowerbed[flowerbed.Length-1]=1;
            n--;
        }
        return n<=0;
    }



    
}
