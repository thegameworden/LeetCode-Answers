//This problem can be found at: https://leetcode.com/problems/remove-covered-intervals

public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        print(intervals);
        Array.Sort(intervals,Comparer<int[]>.Create((x,y)=>{
              if (x[0] == y[0]){
                if(x[1]>y[1])
                    return-1;
                return 1;
            }
            if (x[0] < y[0]) return -1;
            return 1;})); 
        Console.WriteLine("\n\n");
        print(intervals);

        int count =0;      
        int prev=0;
        int end;  
       foreach(int[] interval in intervals){
           end = interval[1];
           if(prev<end){
               count++;
               prev=end;
           }
       }
        
        return count;
    }
     private void print(int[][] intervals){
        for(int y=0;y<intervals.Length;y++){
            for(int x=0;x<intervals[y].Length;x++){
                Console.Write($"{intervals[y][x]}, ");
            }
            Console.WriteLine();
        }
    }

    
}
/*
  int count = 0;
    int end, prev_end = 0;
    for (int[] curr : intervals) {
      end = curr[1];
      // if current interval is not covered
      // by the previous one
      if (prev_end < end) {
        ++count;
        prev_end = end;
      }
    }

*/
