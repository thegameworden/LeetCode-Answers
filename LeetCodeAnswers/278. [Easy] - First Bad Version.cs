//This problem can be found at: https://leetcode.com/problems/first-bad-version

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        return badVersionDriver(1,n);
    }
    private int badVersionDriver(int left, int right){
        if(IsBadVersion(left)){
            return left;
        }
        long mid = ((long)left+(long)right)/2;
        int middle = (int) mid;
        if(left==middle)
            return right;

        if(IsBadVersion(middle)){
            return badVersionDriver(left+1,middle);
        }
           return badVersionDriver(middle,right);
        
        
    }
}
