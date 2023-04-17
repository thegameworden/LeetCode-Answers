//This problem can be found at: https://leetcode.com/problems/html-entity-parser

public class Solution {
     
    public string EntityParser(string text) {
     Dictionary<string,string> changer= new Dictionary<string,string>();
        changer.Add("&quot;","\"");
        changer.Add("&apos;","\'");
        changer.Add("&gt;",">");
        changer.Add("&amp;","&");
        changer.Add("&lt;","<");
        changer.Add("&frasl;","/");

        foreach(KeyValuePair<string,string> kvp in changer){
            text=text.Replace(kvp.Key,kvp.Value);
        }
        return text;
    }
}
