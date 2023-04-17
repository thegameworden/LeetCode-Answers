//This problem can be found at: https://leetcode.com/problems/reverse-words-in-a-string-iii

public class Solution {
    public string ReverseWords(string s) {
        string[] strArr = s.Split(' ');
        int pointer=0;
        while(pointer<strArr.Length){
            char[] temp = strArr[pointer].ToCharArray();
            Array.Reverse(temp);
            strArr[pointer]= new string(temp);
            pointer++;
        }
        
        StringBuilder sb = new StringBuilder();
        
        foreach(string str in strArr){
            sb.Append(str);
            sb.Append(" ");
        }
        
        string ret= sb.ToString();
        return ret.Trim();
        
        
        
    }
}




/*
"Let's take LeetCode contest"

["Let's", "take", "LeetCode", "contest"]

foreach{

"Let's" -> array of chars

reverse -> ['L','e','t','\'', 's']  .toString();
}

String Builder

foreach string {
sb.Append(string);
sb.Append(" ");
}

string ret sb.ToString();

ret.Trim

return ret
*/
