//This problem can be found at: https://leetcode.com/problems/long-pressed-name

public class Solution {
    public bool IsLongPressedName(string name, string typed) {
        int nPointer = 0; 
        for (int i = 0; i < typed.Length;i++){
            if (nPointer < name.Length && name[nPointer] == typed[i])
                nPointer++;
            else if (i == 0 || typed[i] != typed[i - 1])
                return false;
        }
        return nPointer == name.Length;
    }
}
