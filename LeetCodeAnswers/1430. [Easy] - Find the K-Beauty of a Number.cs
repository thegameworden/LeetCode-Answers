//This problem can be found at: https://leetcode.com/problems/find-the-k-beauty-of-a-number

public class Solution {
    public int DivisorSubstrings(int num, int k) {
        int kBeauty=0;
        int kSize = (int)Math.Pow(10,k);
        int main = num;
        while(num>=(int)Math.Pow(10,k-1)){
            int test = num%kSize;
            Console.WriteLine(test);
            if(test!=0 && main%test==0){
            kBeauty++;
            }
            num/=10;
        }
        return kBeauty;
    }
}
