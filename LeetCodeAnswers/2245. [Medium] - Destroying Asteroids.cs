//This problem can be found at: https://leetcode.com/problems/destroying-asteroids

public class Solution {
    public bool AsteroidsDestroyed(int mass, int[] asteroids) {
        Array.Sort(asteroids);
        long m = mass;
        for(int i=0;i<asteroids.Length;i++){
            if(m<asteroids[i])
            return false;

            m+=asteroids[i];
        }
        return true;
    }
}
