//This problem can be found at: https://leetcode.com/problems/categorize-box-according-to-criteria

public class Solution {
    public string CategorizeBox(int length, int width, int height, int mass) {
    bool heavy= mass>=100;
    bool bulky = length>=10000|| width>=10000|| height>=10000|| CheckVolume(length,width,height);
       
        //Console.WriteLine($"Testing: {heavy} {bulky}");
        if(heavy&&bulky)
            return "Both";
        if(heavy)
            return "Heavy";
        if(bulky)
            return "Bulky";
        
        return "Neither";
            
       
        }
    
         private bool CheckVolume(int length, int width, int height){
              //Console.WriteLine($"VolumeCheck: {CountDigits(length)}+{CountDigits(width)}+{CountDigits(height)}");
            if(CountDigits(length)+CountDigits(width)+CountDigits(height)>=9){
                return true;
            }
             
            return false;
         }
        private double CountDigits(int num){
            return Math.Log10(num);
        }
    }
