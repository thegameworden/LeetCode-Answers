//This problem can be found at: https://leetcode.com/problems/word-search

public class Solution {
    public bool Exist(char[][] board, string word) {
        int width = board[0].Length;
        int height = board.Length;
        bool[][] check = new bool[height][];
        
        for(int i=0;i<height;i++){
            check[i]=new bool[width];
        }
        
        
        bool traverse(int x, int y, int cPos){
            if(cPos==word.Length){
                return true;
            }
         if(x<0||y<0|| x>=width ||y>=height|| check[y][x]==true|| board[y][x]!= word[cPos]){
             
             return false;
         }
            check[y][x]=true;
            bool ret = traverse(x+1,y,cPos+1)|| traverse(x-1,y,cPos+1)||traverse(x,y+1,cPos+1)|| traverse(x,y-1,cPos+1);
            check[y][x]=false;
          return ret;
            
        }
        
        
       for(int i=0;i<width;i++){
           for(int j=0;j<height;j++){
               if(traverse(i,j,0)==true)
                   return true;
           }
       }
        
        return false;
    }
}
