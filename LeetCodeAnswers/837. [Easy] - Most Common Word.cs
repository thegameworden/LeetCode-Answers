//This problem can be found at: https://leetcode.com/problems/most-common-word

using System.Text.RegularExpressions;
public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        Dictionary<string,int> wordCount = new Dictionary<string,int>();
        paragraph = Regex.Replace(paragraph.ToLower(),@"[^0-9a-zA-Z]+", " ");
        string[] words = paragraph.Split(' ');
        for(int i=0;i<words.Length;i++){
            string lowerTemp = words[i];
            Console.WriteLine(lowerTemp);
            if(wordCount.ContainsKey(lowerTemp)){
                wordCount[lowerTemp]++;
            }else{
                wordCount.Add(lowerTemp,1);
            }
        }
        
        var sortedDict= from word in wordCount orderby word.Value descending select word;
        foreach(KeyValuePair<string,int> kvp in sortedDict){
            Console.WriteLine($"\"{kvp.Key}\" shows up: {kvp.Value} times.");
            if(!Array.Exists(banned, element=> element == kvp.Key) && kvp.Key !=""){
                return kvp.Key;
            }
        }
        
        return "";
        
        
    }
}

/*
Split paragraph to get each word
add each word to dictionary as lowercase (value is word count)



var sortedDict = from entry in myDict orderby entry.Value ascending select entry;
    Array.Exists(planets, element => element == "Pluto"));
*/
