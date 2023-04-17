//This problem can be found at: https://leetcode.com/problems/maximum-number-of-balloons

public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char,int> count = new();
        count.Add('b',0);
        count.Add('a',0);
        count.Add('l',0);
        count.Add('o',0);
        count.Add('n',0);
        for(int i=0;i<text.Length;i++){
            if(count.ContainsKey(text[i])){
                count[text[i]]++;
            }
        }
        return Math.Min(count['b'],Math.Min(count['a'],Math.Min(count['l']/2,Math.Min(count['o']/2,count['n']))));
    }
}
