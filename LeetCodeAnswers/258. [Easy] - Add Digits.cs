//This problem can be found at: https://leetcode.com/problems/add-digits

public class Solution {
    public int AddDigits(int num) {
    if (num == 0)    
    return 0;
return 1 + (num -1 )%9;
}
}
