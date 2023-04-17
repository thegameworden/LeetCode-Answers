//This problem can be found at: https://leetcode.com/problems/detect-capital

public class Solution {
    public bool DetectCapitalUse(string word) {
        return isCaps(word) || noCaps(word) || firstCap(word);
    }

    private bool isCaps(string word){
        for(int i=0;i<word.Length;i++){
            if((int)word[i] >96)
            return false;
        }
        Console.WriteLine("all cap true");
        return true;
    }
    private bool noCaps(string word){
        for(int i=0;i<word.Length;i++){
            if((int)word[i] <96)
            return false;
        }
        Console.WriteLine("no cap true");
        return true;
    }
    private bool firstCap(string word){
        if((int)word[0]>96){
            
        return false;
        }

        for(int i=1;i<word.Length;i++){
            
            if((int)word[i] <96)
            return false;
        }
        Console.WriteLine("first cap true");
        return true;
    }
}
