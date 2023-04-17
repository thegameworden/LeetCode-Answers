//This problem can be found at: https://leetcode.com/problems/find-k-length-substrings-with-no-repeated-characters

public class Solution {
    public int NumKLenSubstrNoRepeats(string s, int k) {
        int total=0;
        for(int i=0;i<=s.Length-k;i++){
            HashSet<char> check = new HashSet<char>();
           // Console.WriteLine("NEW CHECK");
            for(int j=i;j<k+i;j++){
             //   Console.WriteLine(s[j]);
                check.Add(s[j]);
            }
            if(check.Count== k){
            //    Console.WriteLine("YUPPP");
                total++;
            }
        }
        return total;
    }
}
