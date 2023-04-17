//This problem can be found at: https://leetcode.com/problems/compare-version-numbers

public class Solution {
    public int CompareVersion(string version1, string version2) {
        int[] v1 = convertToIntArr(version1);
        int[] v2 = convertToIntArr(version2);
        
        for(int i=0;i<Math.Min(v1.Length,v2.Length);i++){
            if(v1[i]<v2[i]){
                return -1;
            }
            if(v1[i]>v2[i]){
                return 1;
            }
        }
        
        if(v1.Length>v2.Length){
            for(int i=v2.Length;i<v1.Length;i++){
                if(v1[i]!=0){
                    return 1;
                }
            }
        }else{
            for(int i=v1.Length;i<v2.Length;i++){
                if(v2[i]!=0){
                    return -1;
                }
            }
        }
        
        
        return 0;
        
        
        
    }
    
    private int[] convertToIntArr(string v){
        string[] temp = v.Split('.');
        int[] ret = new int[temp.Length];
        
        for(int i=0;i<ret.Length;i++){
            ret[i]= Int32.Parse(temp[i]);
        }
        return ret;
    }
}

/*
method return int[]{
split into string[]
int[same size] traverse and parse each string
}

traverse the length of the shortest???
if(v1 or v2 is greater, return it)


for(the rest of the longer v)
if(!= 0) return longer

return 0;


v1 [1,0]
v2 [1,0,0]


*/
