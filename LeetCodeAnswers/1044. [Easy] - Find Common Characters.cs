//This problem can be found at: https://leetcode.com/problems/find-common-characters

public class Solution {
    public IList<string> CommonChars(string[] words) {
     List<string> common = new();

     Dictionary<char,int> word1 = new();
     for(int i=0;i<words[0].Length;i++){
         if(word1.ContainsKey(words[0][i])){
             word1[words[0][i]]++;
         }else{
             word1.Add(words[0][i],1);
         }
     }

    for(int i=1;i<words.Length;i++){
        foreach(KeyValuePair<char,int> kvp in word1){
            int counter= 0;
            for(int j=0;j<words[i].Length;j++){
                if(words[i][j]==kvp.Key)
                counter++;
            }

            word1[kvp.Key]=Math.Min(counter,kvp.Value);
        }
    }

    foreach(KeyValuePair<char,int> kvp in word1){
        for(int i=0;i<kvp.Value;i++){
            common.Add(Char.ToString(kvp.Key));
        }
    }


     return common;

    }

    }
