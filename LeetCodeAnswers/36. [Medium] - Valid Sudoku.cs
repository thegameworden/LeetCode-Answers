//This problem can be found at: https://leetcode.com/problems/valid-sudoku

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        return checkRows(board) && checkColumns(board) && checkSubBoxes(board);
    }
    
    private bool checkRows(char[][] board){
        for(int i=0;i<board.Length;i++){
            if(!checkRow(board,i)){
                return false;
            }
        }
        return true;
        
    }
    
    private bool checkRow(char[][] board, int row){
        List<char> checker = new List<char>();
        for(int i=0;i<board[row].Length;i++){
            if(board[row][i]!='.'){
            if(checker.Contains(board[row][i])){
                
                return false;
            }else{
                checker.Add(board[row][i]);
            }
            }
        }
        return true;
    }
    
    
    private bool checkColumns(char[][] board){
        for(int i=0;i<board[0].Length;i++){
            if(!checkCol(board,i)){
             
                return false;
            }
        }
        return true;
        
    }
    
     private bool checkCol(char[][] board, int col){
        List<char> checker = new List<char>();
        for(int i=0;i<board.Length;i++){
            if(board[i][col]!='.'){
            if(checker.Contains(board[i][col])){
                return false;
            }else{
                checker.Add(board[i][col]);
            }
            }
        }
        return true;
    }
    
    
    private bool checkSubBoxes(char[][] board){
        for(int y = 0;y<board.Length;y=y+3){
           for(int x=0;x<board.Length;x=x+3){
               if(!checkSubBox(board,x,y)){
                    
                   return false;
               }
           }
        }
        return true;
        
        
    }
    
    private bool checkSubBox(char[][] board, int x, int y){
        List<char> checker = new List<char>();
        for(int i=y;i<y+3;i++){
            for(int j=x;j<x+3;j++){
                if(board[i][j]!='.'){
                if(checker.Contains(board[i][j])){
                    return false;
                }else{
                    checker.Add(board[i][j]);
                }
                }
            }
        }
        
        return true;
    }
}
