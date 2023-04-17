//This problem can be found at: https://leetcode.com/problems/decode-xored-array

public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] ret = new int[encoded.Length+1];
        ret[0]= first;
        for(int i=1;i<ret.Length;i++){
           //ret[i]= (encoded[i-1]&~ret[i-1]) | (~encoded[i-1] & ret[i-1]);

            ret[i]= encoded[i-1] ^ ret[i-1];
            //is in c and not in a  <- is in b
            //not in c and in a <- is in b
            /*
            b = (c && !a) || (!c && a) 

            */
        }
        return ret;

    }
}
/*

[_,1,2,3] encoded

[1,0,2,1] arr

10
01
11

1 xor _ = 1

a XOR b = c

c ___ a = b



a=111
b=111
c=000

a=000
b=111
c=111
*/
