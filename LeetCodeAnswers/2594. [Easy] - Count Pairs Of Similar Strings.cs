//This problem can be found at: https://leetcode.com/problems/count-pairs-of-similar-strings

public class Solution {
    public int SimilarPairs(string[] words) {
        List<HashSet<char>> wordSets = new List<HashSet<char>>();
        
        for(int i=0;i<words.Length;i++){
            HashSet<char> hSet= new HashSet<char>(); 
            for(int j=0;j<words[i].Length;j++){
                hSet.Add(words[i][j]);
            }
            wordSets.Add(hSet);
        }
        
        int counter=0;
        for(int i=0;i<wordSets.Count-1;i++){
            for(int j=i+1;j<wordSets.Count;j++){
                if(wordSets[i].SetEquals(words[j]))
                    counter++;
            }
        }
        return counter;
        
    }
}
