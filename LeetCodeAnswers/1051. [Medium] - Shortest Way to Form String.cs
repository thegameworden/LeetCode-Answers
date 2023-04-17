//This problem can be found at: https://leetcode.com/problems/shortest-way-to-form-string

public class Solution {
    public int ShortestWay(string source, string target) {
    int counter=0;
    int tPointer=0;
        
        while(tPointer<target.Length){
            if(!source.Contains(target[tPointer])){
                return-1;
            }
            for(int i=0;i<source.Length;i++){
                if(source[i]==target[tPointer]){
                    tPointer++;
                    if(tPointer==target.Length)
                        break;
                }
            }
            
            
            counter++;
        }
        return counter;
        
    }
}
