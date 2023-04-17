//This problem can be found at: https://leetcode.com/problems/letter-tile-possibilities

public class Solution {
    public int NumTilePossibilities(string tiles) {
         Dictionary<char, int> freq = new Dictionary<char, int>();
    foreach (char c in tiles) {
        if (freq.ContainsKey(c)) {
            freq[c]++;
        } else {
            freq[c] = 1;
        }
    }

    // Recursively calculate the number of possible sequences
    return CountPossibilities(freq);
    }
    
    private int CountPossibilities(Dictionary<char, int> freq) {
    int count = 0;
    foreach (char c in freq.Keys) {
        if (freq[c] > 0) {
            // Add the current letter to the sequence
            count++;

            // Decrement the frequency of the current letter and recursively count possibilities
            freq[c]--;
            count += CountPossibilities(freq);

            // Restore the frequency of the current letter
            freq[c]++;
        }
    }
    return count;
}
}
