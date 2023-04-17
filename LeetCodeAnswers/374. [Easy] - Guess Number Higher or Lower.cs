//This problem can be found at: https://leetcode.com/problems/guess-number-higher-or-lower

/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        return guessDriver(0,n);
    }
    
    private int guessDriver(int low, int high){
        
        long mid = ((long)low+ (long)high)/2;
        int middle = (int)mid;
        
        if(guess(middle)==0){
            return middle;
        }else if(guess(middle)==-1){
          return guessDriver(low, middle-1); 
        }
        
        else{
           return guessDriver(middle+1,high);
        }
        
        
    }
}
