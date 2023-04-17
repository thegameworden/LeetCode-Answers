//This problem can be found at: https://leetcode.com/problems/rotated-digits

public class Solution {
     Dictionary<char,char> rotate;
    public int RotatedDigits(int n) {
        rotate = new Dictionary<char,char>();
        rotate.Add('0','0');
        rotate.Add('1','1');
        rotate.Add('8','8');
        rotate.Add('2','5');
        rotate.Add('5','2');
        rotate.Add('6','9');
        rotate.Add('9','6');
        
        if(n==1){
            return 0;
        }
        
        
        int counter=0;
        for(int i=1;i<=n;i++){
            if(valid(i)){
                counter++;
            }
        }
        
        return counter;
    }
    
    
    private bool valid(int num){
        string strNum= num.ToString();
        int pointer=0;
        while(pointer<strNum.Length){
            
            if(!rotate.ContainsKey(strNum[pointer])){
                return false;
            }else{
                strNum= strNum.Remove(pointer,1).Insert(pointer,rotate[strNum[pointer]].ToString());
                //strNum= strNum.Insert(0,rotate[strNum[pointer]].ToString());
            }
            
            
            pointer++;
        }
    
        if(Int32.Parse(strNum) == num){
            return false;
        }
        
        
        
        return true;
    }
}
