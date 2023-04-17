//This problem can be found at: https://leetcode.com/problems/smallest-value-of-the-rearranged-number

public class Solution {
    
    public long Minimize(string str) {
        var count = new Dictionary<char, int>();
        foreach (char c in str) {
            if (count.ContainsKey(c)) {
                count[c]++;
            }
            else {
                count[c] = 1;
            }
        }
 
        char smallest = count.Keys.Where(k => k != '0').Min();
        var ans = new List<char> { smallest };
        count[smallest]--;
 
        foreach (char c in "0123456789") {
            while (count.ContainsKey(c) && count[c] > 0) {
                ans.Add(c);
                count[c]--;
            }
        }
 
        return long.Parse(new string(ans.ToArray()));
    }
    
    public long Maximize(string str) {
        var count = new Dictionary<char, int>();
        foreach (char c in str) {
            if (count.ContainsKey(c)) {
                count[c]++;
            }
            else {
                count[c] = 1;
            }
        }
 
        var ans = new List<char>();
        foreach (char c in "9876543210") {
            while (count.ContainsKey(c) && count[c] > 0) {
                ans.Add(c);
                count[c]--;
            }
        }
 
        return long.Parse(new string(ans.ToArray()));
    }
    
    public long SmallestNumber(long num) {
        if (num == 0) {
            return 0;
        }
        
        string values = Math.Abs(num).ToString();
        return num >= 0 ? Minimize(values) : -Maximize(values);
    }
}
