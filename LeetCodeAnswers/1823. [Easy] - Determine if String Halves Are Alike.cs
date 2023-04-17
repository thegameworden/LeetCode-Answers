//This problem can be found at: https://leetcode.com/problems/determine-if-string-halves-are-alike

public class Solution {
    public bool HalvesAreAlike(string s) {
       int count=0;
        s=s.ToLower();
        const string vowels= "aeiou";
        Console.WriteLine(s);
        for(int i=0;i<s.Length/2;i++){
            if(vowels.IndexOf(s[i])>=0)
                count++;
            
            if(vowels.IndexOf(s[i+s.Length/2])>=0)
            count--;
        }
        return count==0;
    }
}
