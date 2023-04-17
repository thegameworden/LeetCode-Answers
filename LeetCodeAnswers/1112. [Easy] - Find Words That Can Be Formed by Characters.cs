//This problem can be found at: https://leetcode.com/problems/find-words-that-can-be-formed-by-characters

public class Solution {
    public int CountCharacters(string[] words, string chars) {
        Dictionary<char,int> usableChars = new Dictionary<char,int>();
        for(int i=0;i<chars.Length;i++){
            
            if(usableChars.ContainsKey(chars[i])){
                usableChars[chars[i]]++;
            }else{
                usableChars.Add(chars[i],1);
            }
        }
        
        int counter=0;
        for(int i=0;i<words.Length;i++){
            var temp = usableChars.ToDictionary(entry=> entry.Key, entry=> entry.Value );
            if(check(temp,words[i])){
                counter+=words[i].Length;
            }
        }
        
        return counter;
    }
    
    
    private bool check(Dictionary<char,int> usableChars, string word){
      //  Console.WriteLine($"Testing {word}");
        for(int i=0;i<word.Length;i++){
            if(!usableChars.ContainsKey(word[i])){
          //      Console.WriteLine($"{word[i]} not found");
                return false;
            }
            if(usableChars[word[i]]==0){
         //       Console.WriteLine($"Too many of {word[i]} used");
                return false;
            }
            usableChars[word[i]]--;
        }
     //   Console.WriteLine("YUPPPPPP");
        return true;
    }
}
