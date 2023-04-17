//This problem can be found at: https://leetcode.com/problems/sort-the-students-by-their-kth-score

public class Solution {
    public int[][] SortTheStudents(int[][] score, int k)=>
        score.OrderByDescending(s => s[k]).ToArray();

}
