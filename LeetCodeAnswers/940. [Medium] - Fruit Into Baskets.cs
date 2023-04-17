//This problem can be found at: https://leetcode.com/problems/fruit-into-baskets

public class Solution {
    public int TotalFruit(int[] fruits) {
    if(fruits.Length<=2){
        return fruits.Length;
    }
    int fruit1= fruits[0];
    int fruit2=-1;
    int max = 1;
    int count = 1;
        int beginning=0;
        
        for(int i=1;i<fruits.Length;i++){
            if(fruits[i]==fruit1 || fruits[i]== fruit2){
                count++;
            }else{
                max= Math.Max(max,count);
                fruit1=fruits[i-1];
                fruit2=fruits[i];
                count=i-beginning+1;
                
            }
            
            if(fruits[i]!=fruits[i-1]){
                beginning=i;
            }
        }
        return Math.Max(max,count);      
    }
}
