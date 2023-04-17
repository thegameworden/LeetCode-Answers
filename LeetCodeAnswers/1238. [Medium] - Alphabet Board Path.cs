//This problem can be found at: https://leetcode.com/problems/alphabet-board-path

public class Solution {
    Dictionary<char,int[]> d;
    public string AlphabetBoardPath(string target) {
         d = new Dictionary<char,int[]>();
        d.Add('a',new int[]{0,0});
         d.Add('b',new int[]{0,1});
         d.Add('c',new int[]{0,2});
         d.Add('d',new int[]{0,3});
         d.Add('e',new int[]{0,4});
         d.Add('f',new int[]{1,0});
         d.Add('g',new int[]{1,1});
         d.Add('h',new int[]{1,2});
         d.Add('i',new int[]{1,3});
         d.Add('j',new int[]{1,4});
         d.Add('k',new int[]{2,0});
         d.Add('l',new int[]{2,1});
         d.Add('m',new int[]{2,2});
         d.Add('n',new int[]{2,3});
         d.Add('o',new int[]{2,4});
         d.Add('p',new int[]{3,0});
         d.Add('q',new int[]{3,1});
         d.Add('r',new int[]{3,2});
         d.Add('s',new int[]{3,3});
         d.Add('t',new int[]{3,4});
         d.Add('u',new int[]{4,0});
         d.Add('v',new int[]{4,1});
         d.Add('w',new int[]{4,2});
         d.Add('x',new int[]{4,3});
         d.Add('y',new int[]{4,4});
         d.Add('z',new int[]{5,0});
        
        
        int[] position = new int[]{0,0};
        List<char> moves = new List<char>();
        
        mover(moves, 'a', target, 0);
        
        return new string(moves.ToArray());
    }
    
    private void mover(List<char> moves, char current, string target, int pointer){
        if(pointer==target.Length){
            return;
        }

        int goLR=0;
        int goUD=0;
        
        if(target[pointer]=='z'){
             goLR = d[current][1];
             goUD = 5-d[current][0];
            
            for(int i=0;i<goLR;i++){
                moves.Add('L');
            }
            for(int i=0;i<goUD;i++){
                moves.Add('D');
            }
            
            moves.Add('!');
            
            }else if(current=='z'){
             goUD = 5-d[target[pointer]][0];
             goLR = d[target[pointer]][1];
            
            for(int i=0;i<goUD;i++){
                moves.Add('U');
            }
            for(int i=0;i<goLR;i++){
                moves.Add('R');
            }
            moves.Add('!');
            
        }else{
            goLR= d[target[pointer]][1]-d[current][1];
            goUD= d[target[pointer]][0]-d[current][0];
            
            for(int i=0;i<Math.Abs(goLR);i++){
                if(goLR>0){
                    moves.Add('R');
                }
                if(goLR<0){
                    moves.Add('L');
                }
            }
             for(int i=0;i<Math.Abs(goUD);i++){
                if(goUD>0){
                    moves.Add('D');
                }
                if(goUD<0){
                    moves.Add('U');
                }
            }
            moves.Add('!');  
        }
        
        
        
        mover(moves, target[pointer], target, pointer+1);
    }
}
