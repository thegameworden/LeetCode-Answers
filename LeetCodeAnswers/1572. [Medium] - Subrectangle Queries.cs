//This problem can be found at: https://leetcode.com/problems/subrectangle-queries

public class SubrectangleQueries {
    int[][] sRect;
    public SubrectangleQueries(int[][] rectangle) {
        sRect = rectangle;
    }
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
        for(int y=row1;y<=row2;y++){
            for(int x=col1;x<=col2;x++){
                sRect[y][x]=newValue;
            }
        }
    }
    
    public int GetValue(int row, int col) {
        return sRect[row][col];
    }
}

/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */
