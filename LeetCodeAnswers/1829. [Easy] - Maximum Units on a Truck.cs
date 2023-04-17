//This problem can be found at: https://leetcode.com/problems/maximum-units-on-a-truck

public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        for(int i=0;i<boxTypes.Length;i++){
            Console.WriteLine($"{boxTypes[i][0]} {boxTypes[i][1]}");
        }
        Array.Sort(boxTypes, (a,b) => {return b[1]-a[1];});
        Console.WriteLine();
    
        
        int counter=0;
        int pointer =0;
        int boxes=0;
        while(boxes<truckSize){
            if(pointer==boxTypes.Length){
                return counter;
            }
            
            if(boxTypes[pointer][0]>0){
                counter=counter+ boxTypes[pointer][1];
                boxTypes[pointer][0]--;
                boxes++;
            }else{
                pointer++;
            }
        }
        
        return counter;
    }
}
