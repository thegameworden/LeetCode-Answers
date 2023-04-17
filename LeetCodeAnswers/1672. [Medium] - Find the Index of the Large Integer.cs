//This problem can be found at: https://leetcode.com/problems/find-the-index-of-the-large-integer

/**
 * // This is ArrayReader's API interface.
 * // You should not implement it, or speculate about its implementation
 * class ArrayReader {
 *     // Compares the sum of arr[l..r] with the sum of arr[x..y] 
 *     // return 1 if sum(arr[l..r]) > sum(arr[x..y])
 *     // return 0 if sum(arr[l..r]) == sum(arr[x..y])
 *     // return -1 if sum(arr[l..r]) < sum(arr[x..y])
 *     public int CompareSub(int l, int r, int x, int y) {}
 *
 *     // Returns the length of the array
 *     public int Length() {}
 * }
 */

class Solution {
    public int GetIndex(ArrayReader reader) {
        
        int l=0;
        int y= reader.Length()-1;
        

        while(l<y){
            int third = (y-l+2)/3;
            if(third==0){
                if(reader.CompareSub(l,l,y,y)>0){
                    return l;
                }
                return y;
            }
            int checker = reader.CompareSub(l,l+third-1,y-third+1,y);
           
            if(checker==1){
                y=l+third-1;

            }
            if(checker ==0){
                l=l+third;
                y=y-third;
            }

            if(checker ==-1){
                l=y-third+1;
            }

        }
        return l;
    }
}
