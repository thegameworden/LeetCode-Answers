//This problem can be found at: https://leetcode.com/problems/confusing-number

public class Solution {
    
    Dictionary<char,char> rotator;
    public bool ConfusingNumber(int n) {
        rotator= new Dictionary<char,char>();
        rotator.Add('0','0');
        rotator.Add('1','1');
        rotator.Add('6','9');
        rotator.Add('8','8');
        rotator.Add('9','6');
    
        int rotate= Rotate(n);
        if(rotate<0)
            return false;
        if(rotate!=n){
            return true;
        }
        
        return false;
    }
    
    private int Rotate(int num){
        char[] arr = num.ToString().ToArray();
        Array.Reverse(arr);
        for(int i=0;i<arr.Length;i++){
            //Console.WriteLine(arr[i]);
            if(!rotator.ContainsKey(arr[i])){
                return -1;
            }
            
           // Console.WriteLine(arr[i]);
            arr[i]=rotator[arr[i]];
        }
        string ret = new string(arr);
       // Console.WriteLine($"Rotated result: {ret}");
        return Int32.Parse(ret);
    }
}
