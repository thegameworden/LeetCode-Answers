//This problem can be found at: https://leetcode.com/problems/integer-to-roman

public class Solution {
    
    Dictionary<int, string> map = new Dictionary<int, string>();

    public string IntToRoman(int num) {
        FillHashTable();
        
        StringBuilder sb = new StringBuilder("");
        int[] keys = map.Keys.ToArray();
        int i = 0;
        int key = keys[0];
        while(num > 0){
            int dif = num - key;
            if(dif >= 0)
            {
                sb.Append(map[key]);
                num -= key;
            }
            else
            {
                i++;
                key = keys[i];
            }
        }
        return sb.ToString();
    }
    private void FillHashTable(){
        map.Add(1000, "M");
        map.Add(900, "CM");
        map.Add(500, "D");
        map.Add(400, "CD");
        map.Add(100, "C");
        map.Add(90, "XC");
        map.Add(50, "L");
        map.Add(40, "XL");
        map.Add(10, "X");
        map.Add(9, "IX");
        map.Add(5, "V");
        map.Add(4, "IV");
        map.Add(1, "I");
    }
}
