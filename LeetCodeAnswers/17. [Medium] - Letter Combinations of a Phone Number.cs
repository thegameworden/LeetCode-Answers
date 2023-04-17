//This problem can be found at: https://leetcode.com/problems/letter-combinations-of-a-phone-number

public class Solution {
    public IList<string> LetterCombinations(string digits) {
        var dict = new Dictionary<char, string>
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

            var list = new List<string>();
        
            if(!string.IsNullOrEmpty(digits))
                Backtrack(list, digits, dict, new List<char>(), 0);

            return list;
    }
    
    void Backtrack(List<string> list, string digits, Dictionary<char, string> dict, List<char> temp, int start)
        {
            if (temp.Count == digits.Length) list.Add(string.Join("", temp));

            for (var i = start; i < digits.Length; i++)
            {
                for (var j = 0; j < dict[digits[i]].Length; j++)
                {
                    temp.Add(dict[digits[i]][j]);

                    Backtrack(list, digits, dict, temp, i + 1);

                    temp.RemoveAt(temp.Count - 1);
                }

            }
        }
}
